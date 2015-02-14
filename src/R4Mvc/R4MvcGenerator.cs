using System.Linq;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace R4Mvc
{
	public static class R4MvcGenerator
	{
		private static readonly int[] pramaCodes = { 1591, 3008, 3009, 0108 };

		private const string _headerText = @"
// <auto-generated />
// This file was generated by a R4Mvc.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the r4mvc.json file (i.e. the settings file), save it and rebuild.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress ""Foo hides inherited member Foo.Use the new keyword if hiding was intended."" when a controller and its abstract parent are both processed";

		public static SyntaxNode Generate(CSharpCompilation compiler, ClassDeclarationSyntax[] mvcControllerNodes)
		{
			// Create the root node and add usings, header, pragma
			var fileTree = SyntaxFactory.CompilationUnit();
			fileTree = fileTree.WithUsings("System.CodeDom.Compiler", "Microsoft.AspNet.Mvc", "System.Threading.Tasks");
			fileTree = fileTree.WithHeader(_headerText);
			fileTree = fileTree.WithPragmaCodes(false, pramaCodes);

			// controllers might be in different namespaces so we should group by namespace 
			var namespaceGroups = mvcControllerNodes.GroupBy(x=> x.Ancestors().OfType<NamespaceDeclarationSyntax>().First().Name.ToFullString());
			foreach (var namespaceControllers in namespaceGroups)
			{
				// Grab the first controller node and model and symbol for the controller's namespace
				var firstNode = namespaceControllers.First();
				var firstModel = compiler.GetSemanticModel(firstNode.SyntaxTree);
				var firstSymbol = firstModel.GetDeclaredSymbol(firstNode);
				var namespaceNode = SyntaxHelpers.CreateNamespace(firstSymbol.ContainingNamespace.ToString());
				
				// loop through the controllers and create a partial node for each
				foreach (var mvcControllerNode in mvcControllerNodes)
				{
					var model = compiler.GetSemanticModel(mvcControllerNode.SyntaxTree);
					var mvcSymbol = model.GetDeclaredSymbol(mvcControllerNode);

					// build controller partial class node 
					// add a default constructor if there are some but none are zero length
					var controllerPartialClass = namespaceNode.WithClass(mvcSymbol.Name, mvcControllerNode.TypeParameterList?.Parameters.ToArray());
					if (!mvcSymbol.Constructors.IsEmpty || !mvcSymbol.Constructors.Any(x => x.Parameters.Length == 0))
					{
						controllerPartialClass = controllerPartialClass.WithDefaultConstructor(mvcSymbol);
					}

					// add all method stubs, TODO criteria for this: only public virtual actionresults?
					// add subclasses for action names
					controllerPartialClass = controllerPartialClass.WithMethods(mvcSymbol);
					controllerPartialClass = controllerPartialClass.WithActionNameClass(mvcSymbol);
					controllerPartialClass = controllerPartialClass.WithActionConstantsClass(mvcSymbol);

					namespaceNode = namespaceNode.AddMembers(controllerPartialClass);
					// TODO create T4MVC_[Controller] class inheriting from partial
				}

				fileTree = fileTree.AddMembers(namespaceNode);
			}

			// TODO create static MVC class
			// TODO create static Links class (scripts, content, bundles?)
			// TODO create R4MVCHelpers class

			// reenable pragma codes after last node
			// BUG NormalizeWhitespace is messing up prama (called when writing file)
			fileTree = fileTree.WithPragmaCodes(true, pramaCodes);

			return fileTree;
		}
	}
}
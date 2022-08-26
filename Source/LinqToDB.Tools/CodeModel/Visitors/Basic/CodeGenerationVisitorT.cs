﻿namespace LinqToDB.CodeModel
{
	/// <summary>
	/// Base visitor for code generators for specific languages.
	/// Provides basic code-generation functionality like indented code writer
	/// and some other utility services like:
	/// <list type="bullet">
	/// <item>delimited lists generation</item>
	/// <item>XML writer for XML-doc comments</item>
	/// <item>code fragments generation to string</item>
	/// </list>
	/// </summary>
	/// <typeparam name="TVisitor">Type of visitor implementation.</typeparam>
	internal abstract class CodeGenerationVisitor<TVisitor> : CodeGenerationVisitor
		where TVisitor : CodeGenerationVisitor<TVisitor>
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="newLine">Sequence of characters, used as new line by code writer.</param>
		/// <param name="indent">Sequence of characters, used as one level of indent.</param>
		protected CodeGenerationVisitor(string newLine, string indent)
			: base(newLine, indent)
		{
		}

		/// <summary>
		/// Executes provided action and returns all code, generated by it.
		/// </summary>
		/// <param name="fragmentBuilder">Code generation action.</param>
		/// <returns>Code, generated by <paramref name="fragmentBuilder"/>.</returns>
		protected string BuildFragment(Action<TVisitor> fragmentBuilder) => BuildFragment(() => fragmentBuilder((TVisitor)this));
	}
}

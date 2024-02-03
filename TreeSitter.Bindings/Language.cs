#region File Header
// Filename: Language.cs
// Author: Kalulas
// Create: 2024-2-3
// Description:
#endregion

using System.Runtime.InteropServices;

namespace TreeSitter.Bindings;

public static class Language
{
    [DllImport("tree-sitter-formula.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern IntPtr tree_sitter_formula();

    public static readonly TSLanguage Formula = new TSLanguage(tree_sitter_formula());
}
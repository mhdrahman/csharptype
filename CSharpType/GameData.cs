﻿using System.Collections.Generic;

namespace CSharpType
{
    internal static class GameData
    {
        public static List<string> Snippets = new()
        {
            "var list = new List<string>();",
            "var list = new List<string>(){};",
            "var list = new List<string>{};",
            "List<string> list = new();",
            "List<string> list = new(){};",
            "List<string> list;",

            "var dictionary = new Dictionary<string, string>();",
            "var dictionary = new Dictionary<string, string>(){};",
            "var dictionary = new Dictionary<string, string>{};",
            "Dictionary<string, string> dictionary = new();",
            "Dictionary<string, string> dictionary = new(){};",
            "Dictionary<string, string> dictionary;",

            "var hashSet = new HashSet<string>();",
            "var hashSet = new HashSet<string>(){};",
            "var hashSet = new HashSet<string>{};",
            "HashSet<string> hashSet = new();",
            "HashSet<string> hashSet = new(){};",
            "HashSet<string> hashSet;",

            "public bool Property { get; set; }",
            "public bool Property { get; internal set; }",
            "public bool Property { get; private set; }",
            "public bool Property { get; }",

            "internal bool Property { get; set; }",
            "internal bool Property { get; internal set; }",
            "internal bool Property { get; private set; }",
            "internal bool Property { get; }",

            "private readonly string _foo;",
            "private readonly string _foo = \"bar\";",

            "public static void Method(){}",
            "public static string Method(){}",
            "public static int Method(){}",
            "public static bool Method(){}",
            "public static Task Method(){}",

            "public void Method(){}",
            "public string Method(){}",
            "public int Method(){}",
            "public bool Method(){}",
            "public Task Method(){}",

            "public async Task Method(){}",
            "public async Task<string> Method(){}",
            "public async Task<int> Method(){}",
            "public async Task<bool> Method(){}",

            "(a, b) => true",
            "(a, b) => { return true; }",
            "(a, _) => { return true; }",
            "(_, _) => { return true; }",

            "foreach (var item in collection){}",
            "for (var i = 0; i < collection.Count; i++){}",
            "while(true){}",

            "if (true){}",
            "if (true){} else{}",
            "if (true){} else if(true){} else{}",
        };

        public static List<string> Keywords = new()
        {
            "abstract",
            "as",
            "base",
            "bool",
            "break",
            "byte",
            "case",
            "catch",
            "char",
            "checked",
            "class",
            "const",
            "continue",
            "decimal",
            "default",
            "delegate",
            "do",
            "double",
            "else",
            "enum",
            "event",
            "explicit",
            "extern",
            "false",
            "finally",
            "fixed",
            "float",
            "for",
            "foreach",
            "goto",
            "if",
            "implicit",
            "in",
            "int",
            "interface",
            "internal",
            "is",
            "lock",
            "long",
            "namespace",
            "new",
            "null",
            "object",
            "operator",
            "out",
            "override",
            "params",
            "private",
            "protected",
            "public",
            "readonly",
            "ref",
            "return",
            "sbyte",
            "sealed",
            "short",
            "sizeof",
            "stackalloc",
            "static",
            "string",
            "struct",
            "switch",
            "this",
            "throw",
            "true",
            "try",
            "typeof",
            "uint",
            "ulong",
            "unchecked",
            "unsafe",
            "ushort",
            "using",
            "virtual",
            "void",
            "volatile",
            "while",
            "add",
            "and",
            "alias",
            "ascending",
            "args",
            "async",
            "await",
            "by",
            "descending",
            "dynamic",
            "equals",
            "file",
            "from",
            "get",
            "global",
            "group",
            "init",
            "into",
            "join",
            "let",
            "managed",
            "nameof",
            "nint",
            "not",
            "notnull",
            "nuint",
            "on",
            "or",
            "orderby",
            "partial",
            "record",
            "remove",
            "required",
            "scoped",
            "select",
            "set",
            "unmanaged",
            "value",
            "var",
            "when",
            "where",
            "with",
            "yield",
        };
    }
}

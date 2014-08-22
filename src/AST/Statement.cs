﻿namespace CppSharp.AST
{
    public enum StatementClass
    {
        Any,
        DeclarationReference,
        ConstructorReference,
        CXXOperatorCall
    }

    public abstract class Statement
    {
        public StatementClass Class { get; set; }
        public Declaration Declaration { get; set; }
        public string String { get; set; }
    }
}

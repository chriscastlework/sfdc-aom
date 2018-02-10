// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.61

using System;

#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace CustomLogic
{

    // AomFieldMeta
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.27.0.0")]
    public partial class AomFieldMeta
    {
        public System.Guid Id { get; set; } // ID (Primary key)
        public System.Guid AomMetaId { get; set; } // AomMetaId
        public string Name { get; set; } // Name (length: 250)
        public System.Guid FieldTypeId { get; set; } // FieldTypeId
        public string Display { get; set; } // Display (length: 250)

        // Reverse navigation
        public virtual System.Collections.Generic.List<AomFieldObject> AomFieldObjects { get; set; } // AomFieldObject.FK_dbo.AomFieldObject_dbo.AomFieldMeta_AomFieldMetaId
        public virtual System.Collections.Generic.List<RelationshipMeta> FkAomFieldMeta { get; set; } // RelationshipMeta.FK_dbo.RelationshipMeta_dbo.AomFieldMeta_FkAomFieldMetaId
        public virtual System.Collections.Generic.List<RelationshipMeta> PkAomFieldMeta { get; set; } // RelationshipMeta.FK_RelationshipMeta_AomFieldMeta
        public virtual System.Collections.Generic.List<RelationshipObject> RelationshipObjects { get; set; } // RelationshipObject.FK_dbo.RelationshipObject_dbo.AomFieldMeta_FkAomFieldObjectId

        // Foreign keys
        public virtual AomMeta AomMeta { get; set; } // FK_dbo.AomFieldMeta_dbo.AomMeta_AomMetaId
        public virtual FieldType FieldType { get; set; } // FK_dbo.AomFieldMeta_dbo.FieldTypes_FieldTypeId

        public AomFieldMeta()
        {
            Id = System.Guid.NewGuid();
            Display = "";
            AomFieldObjects = new System.Collections.Generic.List<AomFieldObject>();
            FkAomFieldMeta = new System.Collections.Generic.List<RelationshipMeta>();
            PkAomFieldMeta = new System.Collections.Generic.List<RelationshipMeta>();
            RelationshipObjects = new System.Collections.Generic.List<RelationshipObject>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>

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
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace CustomLogic
{

    // RelationshipMeta
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.27.0.0")]
    public partial class RelationshipMetaMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RelationshipMeta>
    {
        public RelationshipMetaMap()
            : this("dbo")
        {
        }

        public RelationshipMetaMap(string schema)
        {
            ToTable("RelationshipMeta", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PkAomMetaId).HasColumnName(@"PkAomMetaId").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.FkAomMetaId).HasColumnName(@"FkAomMetaId").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.FkAomFieldMetaId).HasColumnName(@"FkAomFieldMetaId").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.PkAomFieldMetaId).HasColumnName(@"PkAomFieldMetaId").HasColumnType("uniqueidentifier").IsRequired();

            // Foreign keys
            HasRequired(a => a.FkAomFieldMeta).WithMany(b => b.FkAomFieldMeta).HasForeignKey(c => c.FkAomFieldMetaId).WillCascadeOnDelete(false); // FK_dbo.RelationshipMeta_dbo.AomFieldMeta_FkAomFieldMetaId
            HasRequired(a => a.FkAomMeta).WithMany(b => b.FkAomMeta).HasForeignKey(c => c.FkAomMetaId).WillCascadeOnDelete(false); // FK_dbo.RelationshipMeta_dbo.AomMeta_FkAomMetaId
            HasRequired(a => a.PkAomFieldMeta).WithMany(b => b.PkAomFieldMeta).HasForeignKey(c => c.PkAomFieldMetaId).WillCascadeOnDelete(false); // FK_RelationshipMeta_AomFieldMeta
            HasRequired(a => a.PkAomMeta).WithMany(b => b.PkAomMeta).HasForeignKey(c => c.PkAomMetaId).WillCascadeOnDelete(false); // FK_dbo.RelationshipMeta_dbo.AomMeta_PkAomMetaId
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>

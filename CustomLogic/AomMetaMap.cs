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

    // AomMeta
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.27.0.0")]
    public partial class AomMetaMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AomMeta>
    {
        public AomMetaMap()
            : this("dbo")
        {
        }

        public AomMetaMap(string schema)
        {
            ToTable("AomMeta", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Display).HasColumnName(@"Display").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>

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

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.27.0.0")]
    public partial class AomDbContext : System.Data.Entity.DbContext, IAomDbContext
    {
        public System.Data.Entity.DbSet<AomFieldMeta> AomFieldMetas { get; set; } // AomFieldMeta
        public System.Data.Entity.DbSet<AomFieldObject> AomFieldObjects { get; set; } // AomFieldObject
        public System.Data.Entity.DbSet<AomMeta> AomMetas { get; set; } // AomMeta
        public System.Data.Entity.DbSet<AomObject> AomObjects { get; set; } // AomObject
        public System.Data.Entity.DbSet<FieldType> FieldTypes { get; set; } // FieldTypes
        public System.Data.Entity.DbSet<RelationshipMeta> RelationshipMetas { get; set; } // RelationshipMeta
        public System.Data.Entity.DbSet<RelationshipObject> RelationshipObjects { get; set; } // RelationshipObject

        static AomDbContext()
        {
            System.Data.Entity.Database.SetInitializer<AomDbContext>(null);
            AomDbContextStaticPartial(); // Create the following method in your partial class: private static void AomDbContextStaticPartial() { }
        }

        public AomDbContext()
            : base("Name=AOMEntities")
        {
            InitializePartial();
        }

        public AomDbContext(string connectionString)
            : base(connectionString)
        {
            InitializePartial();
        }

        public AomDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
            InitializePartial();
        }

        public AomDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            InitializePartial();
        }

        public AomDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
            InitializePartial();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AomFieldMetaMap());
            modelBuilder.Configurations.Add(new AomFieldObjectMap());
            modelBuilder.Configurations.Add(new AomMetaMap());
            modelBuilder.Configurations.Add(new AomObjectMap());
            modelBuilder.Configurations.Add(new FieldTypeMap());
            modelBuilder.Configurations.Add(new RelationshipMetaMap());
            modelBuilder.Configurations.Add(new RelationshipObjectMap());

            OnModelCreatingPartial(modelBuilder);
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AomFieldMetaMap(schema));
            modelBuilder.Configurations.Add(new AomFieldObjectMap(schema));
            modelBuilder.Configurations.Add(new AomMetaMap(schema));
            modelBuilder.Configurations.Add(new AomObjectMap(schema));
            modelBuilder.Configurations.Add(new FieldTypeMap(schema));
            modelBuilder.Configurations.Add(new RelationshipMetaMap(schema));
            modelBuilder.Configurations.Add(new RelationshipObjectMap(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(System.Data.Entity.DbModelBuilder modelBuilder);
    }
}
// </auto-generated>

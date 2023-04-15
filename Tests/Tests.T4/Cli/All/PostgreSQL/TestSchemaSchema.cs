// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using LinqToDB.Tools.Comparers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.PostgreSQL
{
	public static partial class TestSchemaSchema
	{
		public partial class DataContext
		{
			private readonly IDataContext _dataContext;

			public ITable<TestSchemaIdentity> TestSchemaIdentities => _dataContext.GetTable<TestSchemaIdentity>();
			public ITable<Testsamename>       Testsamenames        => _dataContext.GetTable<Testsamename>();
			public ITable<Testserialidentity> Testserialidentities => _dataContext.GetTable<Testserialidentity>();

			public DataContext(IDataContext dataContext)
			{
				_dataContext = dataContext;
			}
		}

		[Table("TestSchemaIdentity", Schema = "test_schema")]
		public class TestSchemaIdentity : IEquatable<TestSchemaIdentity>
		{
			[Column("ID", DataType = DataType.Int32, DbType = "integer", Precision = 32, Scale = 0, IsPrimaryKey = true, IsIdentity = true, SkipOnInsert = true, SkipOnUpdate = true)] public int Id { get; set; } // integer

			#region IEquatable<T> support
			private static readonly IEqualityComparer<TestSchemaIdentity> _equalityComparer = ComparerBuilder.GetEqualityComparer<TestSchemaIdentity>(c => c.Id);

			public bool Equals(TestSchemaIdentity? other)
			{
				return _equalityComparer.Equals(this, other!);
			}

			public override int GetHashCode()
			{
				return _equalityComparer.GetHashCode(this);
			}

			public override bool Equals(object? obj)
			{
				return Equals(obj as TestSchemaIdentity);
			}
			#endregion
		}

		[Table("testsamename", Schema = "test_schema")]
		public class Testsamename : IEquatable<Testsamename>
		{
			[Column("id", DataType = DataType.Int32, DbType = "integer", Precision = 32, Scale = 0, IsPrimaryKey = true, IsIdentity = true, SkipOnInsert = true, SkipOnUpdate = true)] public int Id { get; set; } // integer

			#region IEquatable<T> support
			private static readonly IEqualityComparer<Testsamename> _equalityComparer = ComparerBuilder.GetEqualityComparer<Testsamename>(c => c.Id);

			public bool Equals(Testsamename? other)
			{
				return _equalityComparer.Equals(this, other!);
			}

			public override int GetHashCode()
			{
				return _equalityComparer.GetHashCode(this);
			}

			public override bool Equals(object? obj)
			{
				return Equals(obj as Testsamename);
			}
			#endregion
		}

		[Table("testserialidentity", Schema = "test_schema")]
		public class Testserialidentity : IEquatable<Testserialidentity>
		{
			[Column("ID", DataType = DataType.Int32, DbType = "integer", Precision = 32, Scale = 0, IsPrimaryKey = true, IsIdentity = true, SkipOnInsert = true, SkipOnUpdate = true)] public int Id { get; set; } // integer

			#region IEquatable<T> support
			private static readonly IEqualityComparer<Testserialidentity> _equalityComparer = ComparerBuilder.GetEqualityComparer<Testserialidentity>(c => c.Id);

			public bool Equals(Testserialidentity? other)
			{
				return _equalityComparer.Equals(this, other!);
			}

			public override int GetHashCode()
			{
				return _equalityComparer.GetHashCode(this);
			}

			public override bool Equals(object? obj)
			{
				return Equals(obj as Testserialidentity);
			}
			#endregion
		}

		#region Table Extensions
		public static TestSchemaIdentity? Find(this ITable<TestSchemaIdentity> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<TestSchemaIdentity?> FindAsync(this ITable<TestSchemaIdentity> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<TestSchemaIdentity> FindQuery(this ITable<TestSchemaIdentity> table, int id)
		{
			return table.Where(e => e.Id == id);
		}

		public static TestSchemaIdentity? Find(this ITable<TestSchemaIdentity> table, TestSchemaIdentity @record)
		{
			return table.FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<TestSchemaIdentity?> FindAsync(this ITable<TestSchemaIdentity> table, TestSchemaIdentity @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<TestSchemaIdentity> FindQuery(this ITable<TestSchemaIdentity> table, TestSchemaIdentity @record)
		{
			return table.Where(e => e.Id == @record.Id);
		}

		public static TestSchemaIdentity? FindTestSchemaIdentity(this TestDataDB db, int id)
		{
			return db.GetTable<TestSchemaIdentity>().FirstOrDefault(e => e.Id == id);
		}

		public static Task<TestSchemaIdentity?> FindTestSchemaIdentityAsync(this TestDataDB db, int id, CancellationToken cancellationToken = default)
		{
			return db.GetTable<TestSchemaIdentity>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<TestSchemaIdentity> FindTestSchemaIdentityQuery(this TestDataDB db, int id)
		{
			return db.GetTable<TestSchemaIdentity>().Where(e => e.Id == id);
		}

		public static TestSchemaIdentity? Find(this TestDataDB db, TestSchemaIdentity @record)
		{
			return db.GetTable<TestSchemaIdentity>().FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<TestSchemaIdentity?> FindAsync(this TestDataDB db, TestSchemaIdentity @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<TestSchemaIdentity>().FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<TestSchemaIdentity> FindQuery(this TestDataDB db, TestSchemaIdentity @record)
		{
			return db.GetTable<TestSchemaIdentity>().Where(e => e.Id == @record.Id);
		}

		public static Testsamename? Find(this ITable<Testsamename> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<Testsamename?> FindAsync(this ITable<Testsamename> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<Testsamename> FindQuery(this ITable<Testsamename> table, int id)
		{
			return table.Where(e => e.Id == id);
		}

		public static Testsamename? Find(this ITable<Testsamename> table, Testsamename @record)
		{
			return table.FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<Testsamename?> FindAsync(this ITable<Testsamename> table, Testsamename @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<Testsamename> FindQuery(this ITable<Testsamename> table, Testsamename @record)
		{
			return table.Where(e => e.Id == @record.Id);
		}

		public static Testsamename? FindTestsamename(this TestDataDB db, int id)
		{
			return db.GetTable<Testsamename>().FirstOrDefault(e => e.Id == id);
		}

		public static Task<Testsamename?> FindTestsamenameAsync(this TestDataDB db, int id, CancellationToken cancellationToken = default)
		{
			return db.GetTable<Testsamename>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<Testsamename> FindTestsamenameQuery(this TestDataDB db, int id)
		{
			return db.GetTable<Testsamename>().Where(e => e.Id == id);
		}

		public static Testsamename? Find(this TestDataDB db, Testsamename @record)
		{
			return db.GetTable<Testsamename>().FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<Testsamename?> FindAsync(this TestDataDB db, Testsamename @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<Testsamename>().FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<Testsamename> FindQuery(this TestDataDB db, Testsamename @record)
		{
			return db.GetTable<Testsamename>().Where(e => e.Id == @record.Id);
		}

		public static Testserialidentity? Find(this ITable<Testserialidentity> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<Testserialidentity?> FindAsync(this ITable<Testserialidentity> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<Testserialidentity> FindQuery(this ITable<Testserialidentity> table, int id)
		{
			return table.Where(e => e.Id == id);
		}

		public static Testserialidentity? Find(this ITable<Testserialidentity> table, Testserialidentity @record)
		{
			return table.FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<Testserialidentity?> FindAsync(this ITable<Testserialidentity> table, Testserialidentity @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<Testserialidentity> FindQuery(this ITable<Testserialidentity> table, Testserialidentity @record)
		{
			return table.Where(e => e.Id == @record.Id);
		}

		public static Testserialidentity? FindTestserialidentity(this TestDataDB db, int id)
		{
			return db.GetTable<Testserialidentity>().FirstOrDefault(e => e.Id == id);
		}

		public static Task<Testserialidentity?> FindTestserialidentityAsync(this TestDataDB db, int id, CancellationToken cancellationToken = default)
		{
			return db.GetTable<Testserialidentity>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<Testserialidentity> FindTestserialidentityQuery(this TestDataDB db, int id)
		{
			return db.GetTable<Testserialidentity>().Where(e => e.Id == id);
		}

		public static Testserialidentity? Find(this TestDataDB db, Testserialidentity @record)
		{
			return db.GetTable<Testserialidentity>().FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<Testserialidentity?> FindAsync(this TestDataDB db, Testserialidentity @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<Testserialidentity>().FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<Testserialidentity> FindQuery(this TestDataDB db, Testserialidentity @record)
		{
			return db.GetTable<Testserialidentity>().Where(e => e.Id == @record.Id);
		}
		#endregion
	}
}
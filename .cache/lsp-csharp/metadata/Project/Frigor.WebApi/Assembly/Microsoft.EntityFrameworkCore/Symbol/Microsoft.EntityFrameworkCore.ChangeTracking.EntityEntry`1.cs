#region Assembly Microsoft.EntityFrameworkCore, Version=8.0.19.0, Culture=neutral, PublicKeyToken=adb9793829ddae60
// Microsoft.EntityFrameworkCore.dll
#endregion

#nullable enable

using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Microsoft.EntityFrameworkCore.ChangeTracking
{
    //
    // Summary:
    //     Provides access to change tracking information and operations for a given entity.
    //
    //
    // Type parameters:
    //   TEntity:
    //     The type of entity being tracked by this entry.
    //
    // Remarks:
    //     Instances of this class are returned from methods when using the Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker
    //     API and it is not designed to be directly constructed in your application code.
    //
    //
    //     See Accessing tracked entities in EF Core for more information and examples.
    public class EntityEntry<TEntity> : EntityEntry where TEntity : class
    {
        //
        // Summary:
        //     This is an internal API that supports the Entity Framework Core infrastructure
        //     and not subject to the same compatibility standards as public APIs. It may be
        //     changed or removed without notice in any release. You should only use it directly
        //     in your code with extreme caution and knowing that doing so can result in application
        //     failures when updating to a new Entity Framework Core release.
        [EntityFrameworkInternal]
        public EntityEntry(InternalEntityEntry internalEntry);

        //
        // Summary:
        //     Gets the entity being tracked by this entry.
        public virtual TEntity Entity { get; }

        //
        // Summary:
        //     Provides access to change tracking and loading information for a collection navigation
        //     property that associates this entity to a collection of another entities.
        //
        // Parameters:
        //   propertyExpression:
        //     A lambda expression representing the collection navigation to access information
        //     and operations for.
        //
        // Returns:
        //     An object that exposes change tracking information and operations for the given
        //     navigation property.
        //
        // Remarks:
        //     See Accessing tracked entities in EF Core and Changing foreign keys and navigations
        //     for more information and examples.
        public virtual CollectionEntry<TEntity, TProperty> Collection<TProperty>(Expression<Func<TEntity, IEnumerable<TProperty>>> propertyExpression) where TProperty : class;
        //
        // Summary:
        //     Provides access to change tracking and loading information for a collection navigation
        //     property that associates this entity to a collection of another entities.
        //
        // Parameters:
        //   navigation:
        //     The collection navigation.
        //
        // Returns:
        //     An object that exposes change tracking information and operations for the given
        //     navigation property.
        //
        // Remarks:
        //     See Accessing tracked entities in EF Core and Changing foreign keys and navigations
        //     for more information and examples.
        public virtual CollectionEntry<TEntity, TProperty> Collection<TProperty>(INavigationBase navigation) where TProperty : class;
        //
        // Summary:
        //     Provides access to change tracking and loading information for a collection navigation
        //     property that associates this entity to a collection of another entities.
        //
        // Parameters:
        //   propertyName:
        //     The name of the navigation property.
        //
        // Returns:
        //     An object that exposes change tracking information and operations for the given
        //     navigation property.
        //
        // Remarks:
        //     See Accessing tracked entities in EF Core and Changing foreign keys and navigations
        //     for more information and examples.
        public virtual CollectionEntry<TEntity, TProperty> Collection<TProperty>(string propertyName) where TProperty : class;
        //
        // Summary:
        //     Provides access to change tracking information and operations for a given complex
        //     type property of this entity.
        //
        // Parameters:
        //   propertyExpression:
        //     A lambda expression representing the property to access information and operations
        //     for.
        //
        // Returns:
        //     An object that exposes change tracking information and operations for the given
        //     property.
        //
        // Remarks:
        //     See Accessing tracked entities in EF Core for more information and examples.
        public virtual ComplexPropertyEntry<TEntity, TProperty> ComplexProperty<TProperty>(Expression<Func<TEntity, TProperty>> propertyExpression);
        //
        // Summary:
        //     Provides access to change tracking information and operations for a given complex
        //     type property of this entity.
        //
        // Parameters:
        //   complexProperty:
        //     The property to access information and operations for.
        //
        // Type parameters:
        //   TProperty:
        //     The type of the property.
        //
        // Returns:
        //     An object that exposes change tracking information and operations for the given
        //     property.
        //
        // Remarks:
        //     See Accessing tracked entities in EF Core for more information and examples.
        public virtual ComplexPropertyEntry<TEntity, TProperty> ComplexProperty<TProperty>(IComplexProperty complexProperty);
        //
        // Summary:
        //     Provides access to change tracking information and operations for a given complex
        //     type property of this entity.
        //
        // Parameters:
        //   propertyName:
        //     The property to access information and operations for.
        //
        // Type parameters:
        //   TProperty:
        //     The type of the property.
        //
        // Returns:
        //     An object that exposes change tracking information and operations for the given
        //     property.
        //
        // Remarks:
        //     See Accessing tracked entities in EF Core for more information and examples.
        public virtual ComplexPropertyEntry<TEntity, TProperty> ComplexProperty<TProperty>(string propertyName);
        //
        // Summary:
        //     Provides access to change tracking information and operations for a given property
        //     of this entity.
        //
        // Parameters:
        //   propertyExpression:
        //     A lambda expression representing the property to access information and operations
        //     for.
        //
        // Returns:
        //     An object that exposes change tracking information and operations for the given
        //     property.
        //
        // Remarks:
        //     See Accessing tracked entities in EF Core for more information and examples.
        public virtual PropertyEntry<TEntity, TProperty> Property<TProperty>(Expression<Func<TEntity, TProperty>> propertyExpression);
        //
        // Summary:
        //     Provides access to change tracking information and operations for a given property
        //     of this entity.
        //
        // Parameters:
        //   property:
        //     The property to access information and operations for.
        //
        // Type parameters:
        //   TProperty:
        //     The type of the property.
        //
        // Returns:
        //     An object that exposes change tracking information and operations for the given
        //     property.
        //
        // Remarks:
        //     See Accessing tracked entities in EF Core for more information and examples.
        public virtual PropertyEntry<TEntity, TProperty> Property<TProperty>(IProperty property);
        //
        // Summary:
        //     Provides access to change tracking information and operations for a given property
        //     of this entity.
        //
        // Parameters:
        //   propertyName:
        //     The property to access information and operations for.
        //
        // Type parameters:
        //   TProperty:
        //     The type of the property.
        //
        // Returns:
        //     An object that exposes change tracking information and operations for the given
        //     property.
        //
        // Remarks:
        //     See Accessing tracked entities in EF Core for more information and examples.
        public virtual PropertyEntry<TEntity, TProperty> Property<TProperty>(string propertyName);
        //
        // Summary:
        //     Provides access to change tracking and loading information for a reference (i.e.
        //     non-collection) navigation property that associates this entity to another entity.
        //
        //
        // Parameters:
        //   propertyExpression:
        //     A lambda expression representing the reference navigation to access information
        //     and operations for.
        //
        // Returns:
        //     An object that exposes change tracking information and operations for the given
        //     navigation property.
        //
        // Remarks:
        //     See Accessing tracked entities in EF Core and Changing foreign keys and navigations
        //     for more information and examples.
        public virtual ReferenceEntry<TEntity, TProperty> Reference<TProperty>(Expression<Func<TEntity, TProperty?>> propertyExpression) where TProperty : class;
        //
        // Summary:
        //     Provides access to change tracking and loading information for a reference (i.e.
        //     non-collection) navigation that associates this entity to another entity.
        //
        // Parameters:
        //   navigation:
        //     The reference navigation.
        //
        // Returns:
        //     An object that exposes change tracking information and operations for the given
        //     navigation property.
        //
        // Remarks:
        //     See Accessing tracked entities in EF Core and Changing foreign keys and navigations
        //     for more information and examples.
        public virtual ReferenceEntry<TEntity, TProperty> Reference<TProperty>(INavigationBase navigation) where TProperty : class;
        //
        // Summary:
        //     Provides access to change tracking and loading information for a reference (i.e.
        //     non-collection) navigation that associates this entity to another entity.
        //
        // Parameters:
        //   propertyName:
        //     The name of the navigation property.
        //
        // Returns:
        //     An object that exposes change tracking information and operations for the given
        //     navigation property.
        //
        // Remarks:
        //     See Accessing tracked entities in EF Core and Changing foreign keys and navigations
        //     for more information and examples.
        public virtual ReferenceEntry<TEntity, TProperty> Reference<TProperty>(string propertyName) where TProperty : class;
    }
}
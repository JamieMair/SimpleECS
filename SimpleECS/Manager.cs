using SimpleECS.Factories;
using SimpleECS.Interfaces;
using System.Collections.Generic;

namespace SimpleECS
{
    public class Manager
    {
        #region Fields
        private IDictionary<int, IEntity> _entities;
        private IComponentStorageCollection _components;
        #endregion

        #region Dependencies
        private IEntityFactory _entityFactory;
        #endregion

        #region Constructor
        public Manager(IEntityFactory entityFactory, IComponentStorageCollection _componentsStorage)
        {
            _entityFactory = entityFactory;
            // Temporary - Need to fix
            _entities = new Dictionary<int, IEntity>();
            _components = _componentsStorage;
        }
        #endregion

        #region Entity Handling
        public IEntity CreateEntity()
        {
            var entity = _entityFactory.CreateEntity();
            _entities.Add(entity.GetHashCode(), entity);
            return entity;
        }
        public IEntity GetEntity(int id)
        {
            return _entities.ContainsKey(id) ? _entities[id] : null;
        }
        #endregion

        #region Component Handling
        public T RegisterComponent<T>(T component, IEntity entity) where T : IComponent
        {
            // TODO: Add check to see if valid entity
            component.EntityID = entity.ID;
            // Assume that the type has already been registered
            var componentStore = _components.GetStorage<T>();
            componentStore.Add(component);
            return component;
        }
        public T RemoveComponent<T>(IEntity entity, T component) where T : IComponent
        {
            entity.RemoveComponent(component);
            // Assume that the type has already been registered
            var componentStore = _components.GetStorage<T>();
            componentStore.Remove(component);
            return component;
        }
        public T RemoveComponent<T>(T component) where T : IComponent
        {
            var entity = GetEntity(component.EntityID);
            return RemoveComponent<T>(entity, component);
        }
        #endregion
    }
}

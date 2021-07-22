using SimpleECS.Interfaces;
using System;
using System.Collections.Generic;

namespace SimpleECS.Basic
{
    public class Entity : IEntity
    {
        public int ID { get; set; }

        private Dictionary<Type, IComponent> _components = new Dictionary<Type, IComponent>();

        public T GetComponent<T>() where T : IComponent
        {
            // TODO: Add debug error handling log here
            return (T)_components.GetValueOrDefault(typeof(T));
        }

        public bool HasComponent<T>() where T : IComponent
        {
            return _components.ContainsKey(typeof(T));
        }

        public void RegisterComponent<T>(T component) where T : IComponent
        {
            if (!this.HasComponent<T>())
            {
                component.EntityID = this.ID;
                _components.Add(typeof(T), component);
            } else
            {
                throw new ArgumentException($"Entity {ID} already has a component of type {typeof(T)}.");
            }
        }

        public void RemoveComponent<T>(T component) where T : IComponent
        {
            if (!this.HasComponent<T>())
            {
                _components.Remove(typeof(T));
            }

        }
    }
}

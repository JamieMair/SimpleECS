using SimpleECS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleECS.Basic
{
    public class ComponentStorageCollection : IComponentStorageCollection
    {
        private Dictionary<Type, IComponentStorage<IComponent>> components;

        public void AddStorage<T>(IComponentStorage<T> storage) where T : IComponent
        {
            components.Add(typeof(T), (IComponentStorage<IComponent>)storage);
        }

        public IComponentStorage<T> GetStorage<T>() where T : IComponent
        {
            return (IComponentStorage<T>)components[typeof(T)];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleECS.Interfaces
{
    public interface IEntity
    {
        public int ID { get; set; }

        public void RegisterComponent<T>(T component) where T : IComponent;
        public void RemoveComponent<T>(T component) where T : IComponent;
        public bool HasComponent<T>() where T : IComponent;
        public T GetComponent<T>() where T : IComponent;
    }
}

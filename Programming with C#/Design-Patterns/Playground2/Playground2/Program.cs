using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using Playground2.Structural.Adapter;
using Playground2.Structural.Decorator;
using Playground2.Structural.Decorator.Library;
using Playground2.Structural.Facade;
using Playground2.Structural.Flyweight;
using Playground2.Structural.Proxy;
using Playground2.Structural.Bridge;

using Playground2.Behavioral.ChainOfResponsibility;
using Playground2.Behavioral.Command;
using Playground2.Behavioral.Interpreter;
using Playground2.Behavioral.Iterator;
using Playground2.Behavioral.Mediator;
using Playground2.Behavioral.Memento;
using Playground2.Behavioral.Observer;
using Playground2.Behavioral.Specification;
using Playground2.Behavioral.State;
using Playground2.Behavioral.Strategy;
using Playground2.Behavioral.TemplateMethod;
using Playground2.Behavioral.Visitor;
using Playground2.Creational.ObjectPool;
using Playground2.Creational.Prototype;
using Playground2.Creational.FactoryMethod;
using Playground2.Creational.AbstractFactoryNamespace;
using Playground2.Creational.Builder;
using Playground2.Creational.Singleton;

using Playground2.AmbientContext;

using Ninject.Modules;
using Ninject;
using System.Collections;

namespace Playground2
{
    class MainApp
    {
        static void Main()
        {
            ICollection s = new List<int>();

            IEnumerable a = s;

            // check lazy at ambient context
            // 2 23



            #region all fncs

            //BEHAVIORAL

            //VISITOR

            //Visitor.Run();

            //TEMPLATE METHOD

            //TemplateMethod.Run();

            //STRATEGY

            //StrategyMain.Run();

            //STATE

            //StateMain.Run();

            //SPECIFICATION

            Specification.Run();

            //OBSERVER

            //Observer.Run();

            //MEMENTO

            //MainMemento.Run();

            //MEDIATOR

            //Mediator.Run();

            //ITERATOR

            //Iterator.Run();

            //INTERPRETER

            //Interpreter.Run();

            //COMMAND

            //Command.Run();

            //CHAIN OF RESPONSIBILITY

            //ChainMain.Run();

            //PROXY

            //ProxyMain.Run();

            //FLYWEIGHT

            //FlyweightMain.Run();

            //FACADE

            //FacadeMain.Run();

            //DECORATOR

            //DecoratorMain.Run();

            //BRIDGE

            //BridgeMain.Run();

            //CREATIONAL PATTERNS

            //SIMPLE FACTORY

            //SimpleFactoryMain.Run();

            //LAZY INITIALIZATION

            //LazyInitializationMain.Run();

            //SINGLETON

            //SingletonMain.Run();

            //OBJECT POOL

            //ObjectPoolMain.Run();

            //PROTOTYPE

            //PrototypeMain.Run();

            //BUILDER

            //BuilderMain.Run();

            //ABSTRACT FACTORY

            //AbstractFactoryMain.Run();

            //FACTORY METHOD

            //FactoryMethodMain.Run();

            #endregion
        }

    }
}

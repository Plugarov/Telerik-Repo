namespace AcademyRPG.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using AcademyRPG.Interfaces;

    public class Engine
    {
        private List<IWorldObject> allObjects;
        private List<IControllable> characters;
        protected List<IResource> resources;

        public List<IWorldObject> AllObjects { get => allObjects; set => allObjects = value; }
        public List<IControllable> Characters { get => characters; set => characters = value; }

        public Engine()
        {
            this.AllObjects = new List<IWorldObject>();
            this.Characters = new List<IControllable>();
            this.resources = new List<IResource>();
        }

        private void AddObject(WorldObject obj)
        {
            this.AllObjects.Add(obj);

            IControllable objectAsControllable = obj as IControllable;
            if (objectAsControllable != null)
            {
                this.Characters.Add(objectAsControllable);
            }

            IResource objectAsResource = obj as IResource;
            if (objectAsResource != null)
            {
                this.resources.Add(objectAsResource);
            }

            RemoveDestroyed();
        }

        public void RemoveDestroyed()
        {
            //TODO
        }

        public void ExecuteCommand(string command)
        {
            string[] commandToExecute = command.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (commandToExecute[0] == "create")
            {
                ExecuteCreateObjectCommand(commandToExecute);
            }
            else
            {
                ExecuteActionCommand(commandToExecute);
            }
        }

        private void ExecuteCreateObjectCommand(string[] command)
        {

            switch (command[1])
            {
                case "tree":
                    {
                        int owner = 0;
                        Point position = Point.Parse(command[3]);
                        int size = int.Parse(command[2]);
                        this.AddObject(new Tree(owner, position, size));
                        break;
                    }
                case "guard":
                    {
                        int owner = int.Parse(command[4]);
                        Point position = Point.Parse(command[3]);
                        string name = command[2];
                        this.AddObject(new Guard(owner, position, name));
                        break;
                    }

                case "lumberjack":
                    {
                        int owner = int.Parse(command[4]);
                        Point position = Point.Parse(command[3]);
                        string name = command[2];
                        this.AddObject(new Lamberjack(owner, position, name));
                        break;
                    }
            }
        }

        private void ExecuteActionCommand(string[] command)
        {
            string controllableName = command[0];
            IControllable current = null;

            for (int i = 0; i < this.characters.Count; i++)
            {
                if (controllableName == this.characters[i].Name)
                {
                    current = this.characters[i];
                }
            }

            switch (command[1])
            {
                case "go":
                    HandleGoCommand(command, current);
                    break;
                case "attack":
                    HandleAttackCommand(current);
                    break;
                case "gather":
                    HandleGatherCommand(current);
                    break;
            }
            //engine.ExecuteCommand("<name> go <position> ");
            //engine.ExecuteCommand("<name> attack");
            //engine.ExecuteCommand("<name> gather");
            //engine.ExecuteCommand("create guard Jack (0,0) 1");
        }

        private void HandleGatherCommand(IControllable current)
        {
            var currentAsGatherer = current as IGatherer;
            if (currentAsGatherer != null)
            {
                IResource resource = null;
                foreach (var obj in this.resources)
                {
                    if (obj. == current.Position)
                    {
                        resource = obj;
                        break;
                    }
                }
            }
        }

        private void HandleAttackCommand(IControllable current)
        {

        }

        private void HandleGoCommand(string[] command, IControllable current)
        {
            var currentAsMoving = current as MovingObject;
            currentAsMoving.GoTo(Point.Parse(command[2]));
            Console.WriteLine("{0} is now at position {1}", current, current.Position);
        }
    }
}

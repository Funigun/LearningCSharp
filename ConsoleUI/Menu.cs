﻿using TypeSystemDemo = TypeSystemDemoLibrary;
using ConcreteClass = ConcreteClassDemoLibrary;

namespace ConsoleUI
{
    internal class Menu
    {
        private Dictionary<int, string> _mainMenu;

        private Dictionary<int, Dictionary<int, string>> _subMenu;

        private Dictionary<int, Dictionary<int, Action>> _actions;

        private sbyte _selectedView = -1;
        private sbyte _selectedSubView = -1;

        internal Menu()
        {
            _mainMenu = SetMenuItems();
            _subMenu = SetSubMenuItems();
            _actions = SetActions();
        }

        // Main Menu items
        private Dictionary<int, string> SetMenuItems()
        {
            return new Dictionary<int, string>()
            {
                { 0, "0 - Close application" },                
                { 1, "1 - Type System Demo" },
                { 2, "2 - Concrete Class Demo" },
            };
        }

        // Menu for each of modules
        private Dictionary<int, Dictionary<int, string>> SetSubMenuItems()
        {
            return new Dictionary<int, Dictionary<int, string>>()
            {
                { 1, TypeSystemDemo.Menu.MenuList },
                { 2, ConcreteClass.Menu.MenuList }
            };
        }
        
        // Actions for each of modules
        private Dictionary<int, Dictionary<int, Action>> SetActions()
        {
            return new Dictionary<int, Dictionary<int, Action>>
            {
                { 1, TypeSystemDemo.Menu.MenuActions },
                { 2, ConcreteClass.Menu.MenuActions }
            };
        }

        private void ShowMenu()
        {
            foreach (string item in _mainMenu.Values)
            {
                Console.WriteLine(item);
            }
        }

        private void ShowSubMenu()
        {
            Console.WriteLine("0 - Exit module");

            foreach (string item in _subMenu[_selectedView].Values)
            {
                Console.WriteLine(item);
            }
        }

        internal void Workflow()
        {
            int mainMenuItems = _mainMenu.Keys.Count - 1;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Learning C# demo application.");
                Console.WriteLine($"Please choose module (number from 0 to {mainMenuItems}):\n");
                
                ShowMenu();
                SelectViewToShow(ref _selectedView, mainMenuItems);

                if (_selectedView > 0)
                {
                    int subMenuItems = _subMenu[_selectedView].Keys.Count - 1;

                    Console.Clear();

                    do
                    {
                        Console.WriteLine($"Please choose topic (number from 0 to {subMenuItems}):\n");
                        
                        ShowSubMenu();
                        SelectViewToShow(ref _selectedSubView, mainMenuItems);

                        if (_selectedSubView > 0)
                        {
                            Console.Clear();
                            ShowView();
                            Console.WriteLine("Press any key to continue (this will clear current view).");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    while (_selectedSubView != 0);
                }
            }
            while (_selectedView != 0);
        }

        private void SelectViewToShow(ref sbyte viewToSet, int viewIndexLimit)
        {
            do
            {
                try
                {
                    viewToSet = Convert.ToSByte(Console.ReadLine());
                }
                catch (Exception)
                {
                    viewToSet = -1;
                }

                if (viewToSet == -1 || viewToSet > viewIndexLimit)
                {
                    Console.WriteLine($"Provided value is not correct. Acceptable value is a number from 0 to {viewIndexLimit}.");
                }
            }
            while (viewToSet == -1);
        }

        private void ShowView() => _actions[_selectedView][_selectedSubView].Invoke();
        
    }
}

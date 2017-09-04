using System;
namespace SimpleCQRS
{
    public class Event : Message
    {
        public int Version;
    }
    
    public class InventoryItemDeactivated : Event {
        public readonly Guid Id;

        public InventoryItemDeactivated(Guid id)
        {
            Id = id;
        }
    }

    public class InventoryItemCreated : Event {
        public readonly Guid Id;
        public readonly string Name;
        public InventoryItemCreated(Guid id, string name) {
            Id = id;
            Name = name;
        }
    }

    public class InventoryItemRenamed : Event
    {
        public readonly Guid Id;
        public readonly string NewName;
 
        public InventoryItemRenamed(Guid id, string newName)
        {
            Id = id;
            NewName = newName;
        }
    }

    public class InventoryItemNameDecorated : Event
    {
        public readonly Guid Id;
        public readonly string Name;
        public readonly string Suffix;

        public InventoryItemNameDecorated(Guid id, string name, string suffix)
        {
            Id = id;
            Name = name;
            Suffix = suffix;
        }
    }

    public class ItemsCheckedInToInventory : Event
    {
        public Guid Id;
        public readonly int Count;
 
        public ItemsCheckedInToInventory(Guid id, int count) {
            Id = id;
            Count = count;
        }
    }

    public class ItemsRemovedFromInventory : Event
    {
        public Guid Id;
        public readonly int Count;
 
        public ItemsRemovedFromInventory(Guid id, int count) {
            Id = id;
            Count = count;
        }
    }
}


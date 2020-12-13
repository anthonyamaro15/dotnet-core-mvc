using System;
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
   public class MockCommanderRepo : ICommanderRepo
   {
      public IEnumerable<Command> GetAppCommands()
      {
         var commands = new List<Command>
         {
            new Command{Id = 0, HowTo = "trash out", Line = "walking", Platform = "open door"},
            new Command{Id = 1, HowTo = "cut bread", Line = "get a knife", Platform = "open door"},
            new Command{Id = 2, HowTo = "make coffee", Line = "with water", Platform = "microwave"},
         };
         return commands;
      }

      public Command GetCommandById(int id)
      {
         return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kttle &  Pan" };
      }
   }
}

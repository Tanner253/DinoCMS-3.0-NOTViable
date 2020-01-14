using Scaffold_CMS.Data;
using Scaffold_CMS.Models.Interfaces;
using Scaffold_CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Scaffold_CMS.Models.Services
{
    public class DinosaurService : IDinosaurManager 
    {
        private DinoDbContext _context;

        public DinosaurService(DinoDbContext context)
        {
            _context = context;
        }

        public async Task CreateDinosaur(Dinosaur dinosaur)
        {
            _context.Add(dinosaur);
            await _context.SaveChangesAsync();
            
        }
        public async Task<Dinosaur> DeleteDinosaur(int id)
         {
            Dinosaur dino = await _context.Dinosaur.FirstOrDefaultAsync(m => m.ID == id);
            return dino;
         }
        
        public async Task DeleteDinosaurFR(int id)
        {
            var dino = await _context.Dinosaur.FindAsync(id);
            _context.Dinosaur.Remove(dino);
            await _context.SaveChangesAsync();
        }

        public bool DinosaurExists(int id)
        {
            return _context.Dinosaur.Any(m => m.ID == id);
        }

        public Task<Dinosaur> GetDinosaur(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dinosaur>> GetDinosaurs()
        {
            throw new NotImplementedException();
        }

        public Task UpdateDinosaur(int id, Dinosaur dinosaur)
        {
            throw new NotImplementedException();
        }
    }
}

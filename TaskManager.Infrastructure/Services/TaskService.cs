using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Interfaces;
using TaskManager.Domain.Entities;
using TaskManager.Infrastructure.Data;

namespace TaskManager.Infrastructure.Services
{
    public class TaskService : ITaskService
    {
        private readonly AppDbContext _context;
        public TaskService(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            try
            {
                return await _context.Tasks.OrderBy(t => t.DueDate).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving tasks.", ex);
            }
        }

        public async Task<TaskItem?> GetByIdAsync(int id)
        {
            try
            {
                return await _context.Tasks.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving the task with ID {id}.", ex);
            }
        }

        public async Task CreateAsync(TaskItem task)
        {
            try
            {
                _context.Tasks.Add(task);
                await _context.SaveChangesAsync();

            }catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the task.", ex);
            }
        }

        public async Task UpdateAsync(TaskItem task)
        {
            try
            {
                _context.Tasks.Update(task);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the task.", ex);

            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var task = await _context.Tasks.FindAsync(id);
                if (task == null)
                {
                    throw new Exception($"Task with ID {id} not found.");
                }
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while deleting the task with ID {id}.", ex);
            }
        }
    }
}

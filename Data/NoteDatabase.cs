using System;
using DreamEase.Models;
using SQLite;

namespace DreamEase.Data;

public class NoteDatabase
{
    SQLiteAsyncConnection _database;


    async Task Init()
    {
        if (_database is not null)
            return;

        _database = new SQLiteAsyncConnection(
            Constants.DatabasePath,
            Constants.Flags
        );

        await _database.CreateTableAsync<Note>();
    }

    public async Task<List<Note>> GetNotesAsync()
    {
        await Init();
        return await _database.Table<Note>().ToListAsync();
    }

    public async Task<Note> GetNoteAsync(int noteId)
    {
        await Init();
        return await _database.Table<Note>()
            .Where(n => n.ID == noteId)
            .FirstOrDefaultAsync();
    }

    public async Task<int> SaveNoteAsync(Note note)
    {
        await Init();
        if (note.ID != 0)
        {
            return await _database.UpdateAsync(note);
        }
        else
        {
            return await _database.InsertAsync(note);
        }
    }

    public async Task<int> DeleteNoteAsync(Note note)
    {
        await Init();
        return await _database.DeleteAsync(note);
    }
}


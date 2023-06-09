﻿using PCInfo_backend.Shared.Persistence.Contexts;

namespace PCInfo_backend.Shared.Persistence.Repositories;

public class BaseRepository
{
    protected readonly AppDbContext _context;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }
}
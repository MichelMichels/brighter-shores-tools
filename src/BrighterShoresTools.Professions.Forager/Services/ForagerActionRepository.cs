﻿using BrighterShoresTools.Professions.Core.Data;
using BrighterShoresTools.Professions.Core.Services;

namespace BrighterShoresTools.Professions.Forager.Services;

public class ForagerActionRepository : IProfessionActionRepository
{
    private static List<ProfessionAction> _foragerActions =
        [
            new() {
                Name = "Mauve Bellplant",
                StartingLevel = 12,
                ExperiencePoints = 118
            }
        ];

    public Task<List<ProfessionAction>> GetAll()
    {
        return Task.FromResult(_foragerActions);
    }

    public Task<ProfessionAction?> GetByName(string name)
    {
        ProfessionAction? action = _foragerActions.FirstOrDefault(x => x.Name.Equals(name));
        return Task.FromResult(action);
    }
}

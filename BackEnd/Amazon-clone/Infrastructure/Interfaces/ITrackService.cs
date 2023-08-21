﻿using DAL.Entities;
using DAL.Entities.FilterEntities;
using DAL.Entities.Music;
using Infrastructure.Models;
using Infrastructure.Models.Caterories;
using Services;

namespace Infrastructure.Interfaces
{
    public interface ITrackService
    {
        Task<Track> CreateTrackAsync(TrackDTO model);
        Task<List<TrackVM>> GetAllAsync();
        Task<string> GetMainImageByIdAsync(int id);
        Task<string> GetBackgroundImageByIdAsync(int id);
        Task<List<TrackVM>> GetTracksByUserIdCreatedByUserAsync(int id);
        Task<TrackVM> SetLikedTrackAsync(SetLikedTrackDTO model);
        Task<List<TrackVM>> GetLikedTracksByUserIdAsync(int id);
        Task<List<TrackHistory>> GetAllTrackHistoryAsync();
        Task<TrackHistory> AddTrackHistoryAsync(AddTrackHistoryDTO model);
        Task<List<TrackVM>> GetTrackHistoryByUserIdAsync(FindByIdVM model);
        Task<TrackVM> GetTrackByIdAsync(int id);
        Task DeleteTrackAsync(int id);
        Task<List<TrackVM>> GetSearchTracksByNameAsync(string name);
        
    }
}
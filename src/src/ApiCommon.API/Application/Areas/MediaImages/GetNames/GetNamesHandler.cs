﻿using ApiCommon.API.Application.Abstractions;
using ApiCommon.API.Application.Core;
using ApiCommon.API.Services.General.FileUploadService;
using ApiCommon.Domain.Consts;

namespace ApiCommon.API.Application.Areas.MediaImages.GetNames
{
    public class GetNamesHandler : IHandler
    {
        private readonly FileUploadService _fileUploadService;

        public GetNamesHandler(FileUploadService fileUploadService)
        {
            _fileUploadService = fileUploadService;
        }

        public async Task<Result<GetNamesResponse>> Handle()
        {
            var names = _fileUploadService.GetFileNames(ApiCommonConsts.MediaImagesFolder);
            return Result<GetNamesResponse>.Ok(new GetNamesResponse() { Items = names, });
        }
    }
}

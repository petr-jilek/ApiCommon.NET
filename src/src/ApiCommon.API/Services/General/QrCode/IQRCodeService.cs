﻿namespace ApiCommon.API.Services.General.QrCode
{
    public interface IQrCodeService
    {
        string GenerateQrCode(string text);
    }
}

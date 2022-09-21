﻿namespace ApiCommon.Domain.Error
{
    public static class Errors
    {
        public const string UnknownError = "UnkonwnError";
        public const string UndescribedError = "UndescriptedError";

        public const string EmailIsRequired = "EmailIsRequired";
        public const string EmailIsNotValid = "EmailIsNotValid";
        public const string EmailIsTooLong = "EmailIsTooLong";

        public const string PasswordIsRequired = "PasswordIsRequired";
        public const string PasswordIsTooShort = "PasswordIsTooShort";
        public const string PasswordIsTooLong = "PasswordIsTooLong";

        public const string NewPasswordIsRequired = "NewPasswordIsRequired";
        public const string NewPasswordIsTooShort = "NewPasswordIsTooShort";
        public const string NewPasswordIsTooLong = "NewPasswordIsTooLong";

        public const string BadEmailOrPassword = "BadEmailOrPassword";
        public const string BadPassword = "BadPassword";
        public const string PasswordsDontMatch = "PasswordsDontMatch";

        public const string NameIsRequired = "NameIsRequired";
        public const string NameIsTooLong = "NameIsTooLong";

        public const string PhoneNumberIsRequired = "PhoneNumberIsRequired";
        public const string PhoneNumberIsNotValid = "PhoneNumberIsNotValid";

        public const string EndDateMustBeGreaterThanStartDate = "EndDateMustBeGreaterThanStartDate";

        public const string TextIsTooLong = "TextIsTooLong";

        public const string UnconfirmedReservationAlreadyExists = "UnconfirmedReservationAlreadyExists";

        public const string UserWithEmailAlreadyExists = "UserWithEmailAlreadyExists";

        public const string Empty = "Empty";

        public const string FileIsEmpty = "FileIsEmpty";
        public const string FileNameIsNotValid = "FileNameIsNotValid";
        public const string FileTypeIsNotValid = "FileTypeIsNotValid";
        public const string FileIsNotValid = "FileIsNotValid";
        public const string FileIsTooLarge = "FileIsTooLarge";
        public const string FileAlreadyExists = "FileAlreadyExists";
        public const string FileNotExists = "FileNotExists";

        public const string ArticleNotExists = "ArticleNotExists";
        public const string ArticleAlreadyExists = "ArticleAlreadyExists";

        public const string FundNotExists = "FundNotExists";

        public const string UserNameIsRequired = "UserNameIsRequired";
        public const string UserNameIsTooLong = "UserNameIsTooLong";

        public const string ImageIsRequired = "ImageIsRequired";
        public const string ImageNameIsTooLong = "ImageNameIsTooLong";

        public const string ItemNotExists = "ItemNotExists";
        public const string ItemAlreadyExists = "ItemAlreadyExists";

        public const string EmailSendFailed = "EmailSendFailed";

        public const string MustBePositiveNumber = "MustBePositiveNumber";

        public const string StartDateCannotBeInPast = "StartDateCannotBeInPast";
        public const string StartDateMustBeInFuture = "StartDateMustBeInFuture";
        
        //public const string BadEmail = new("BadEmail");
        //public const string UserWithEmailAlreadyExists = new("UserWithEmailAlreadyExists");
        //public const string BadUserName = new("BadUserName");
        //public const string BadDisplayName = new("BadDisplayName");
        //public const string BadPassword = new("BadPassword");
        //public const string PasswordsDontMatch = new("PasswordsDontMatch");

        //public const string RegistrationError = new("RegistrationError");
        //public const string LoginError = new("LoginError");

        //public const string EmailVerificationError = new("EmailVerificationError");

        //public const string UserWithEmailDoesNotExists = new("UserWithEmailDoesNotExists");
        //public const string AddToRoleError = new("AddToRoleError");

        //public const string AlreadyExists = new("AlreadyExists");
        //public const string TooMany = new("TooMany");

        //public const string NotFound = new("NotFound");

        //public const string CannotDelete = new("CannotDelete");
        //public const string CannotDeleteIsMain = new("CannotDeleteIsMain");
        //public const string CannotCreate = new("CannotCreate");
        //public const string AlreadyDeleted = new("AlreadyDeleted");

        //public const string InvalidData = new("InvalidData");

        //public const string InvalidControllerAction = new("InvalidControllerAction");

        //public const string GoPayError = new("GoPayError");

        //public const string FileEmpty = new("FileEmpty");
        //public const string FileTooLarge = new("FileTooLarge");
        //public const string BadFileName = new("BadFileName");
        //public const string BadFileType = new("BadFileType");
        //public const string FileExists = new("FileExists");
        //public const string FileNotExists = new("FileNotExists");
    }
}

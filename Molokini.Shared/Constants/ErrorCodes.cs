namespace Molokini.Shared.Constants;

public static class ErrorCodes
{ 
    public static class General
    {
        public const string InternalServerError = "GENERAL_INTERNAL_SERVER_ERROR";
        public const string NotFound = "GENERAL_NOT_FOUND";
        public const string BadRequest = "GENERAL_BAD_REQUEST";
        public const string Unauthorized = "GENERAL_UNAUTHORIZED";
        public const string Forbidden = "GENERAL_FORBIDDEN";
        public const string Conflict = "GENERAL_CONFLICT";
        public const string TooManyRequests = "GENERAL_TOO_MANY_REQUESTS";
    }

    public static class Waste
    {
        public const string WasteNotFound = "WASTE_NOT_FOUND";
        public const string WasteAlreadyExists = "WASTE_ALREADY_EXISTS";
        public const string WasteNotValid = "WASTE_NOT_VALID";
        public const string WasteNotAuthorized = "WASTE_NOT_AUTHORIZED";
        public const string WasteNotAuthenticated = "WASTE_NOT_AUTHENTICATED";
    }

    public static class User
    {
        public const string UserNotFound = "USER_NOT_FOUND";
        public const string UserAlreadyExists = "USER_ALREADY_EXISTS";
        public const string UserNotValid = "USER_NOT_VALID";
        public const string UserNotAuthorized = "USER_NOT_AUTHORIZED";
        public const string UserNotAuthenticated = "USER_NOT_AUTHENTICATED";
    }
}
﻿namespace Library
{
    public static class Constants
    {
        public static class ApplicationsUserConstants
        {
            public const int UserNameMaxLength = 20;
            public const int UserNameMinLength = 5;

            public const int EmailMaxLength = 60;
            public const int EmailMinLength = 10;

            public const int PasswordMaxLength = 20;
            public const int PasswordMinLength = 5;
        }

        public static class BookConstants
        {
            public const int TitleMaxLength = 50;
            public const int TitleMinLength = 10;

            public const int AuthorMaxLength = 50;
            public const int AuthorMinLength = 5;

            public const int DescriptionMaxLength = 5000;
            public const int DescriptionMinLength = 5;

            public const double RatingMaxLength = 10.00;
            public const double RatingMinLength = 0.00;
        }

        public static class CategoryConstants
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 5;
        }
    }
}

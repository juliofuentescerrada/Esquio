﻿using Microsoft.Extensions.Logging;
using System;

namespace Esquio.UI.Api.Diagnostics
{
    static class Log
    {
        public static void ApiKeyAlreadyExist(ILogger logger, string apiKeyName)
        {
            _apiKeyAlreadyExist(logger, apiKeyName, null);
        }

        public static void ApiKeyNotExist(ILogger logger, string apiKeyId)
        {
            _apiKeyNotExist(logger, apiKeyId, null);
        }
        public static void FeatureNameAlreadyExist(ILogger logger, string feature)
        {
            _featureNameAlreadyExist(logger, feature, null);
        }

        public static void ProductAlreadyExist(ILogger logger, string product)
        {
            _productAlreadyExist(logger, product, null);
        }

        public static void ProductNotExist(ILogger logger, string product)
        {
            _productNotExist(logger, product, null);
        }

        public static void FeatureNotExist(ILogger logger, string feature)
        {
            _featureNotExist(logger, feature, null);
        }

        public static void ToggleNotExist(ILogger logger, string toggle)
        {
            _toggleNotExist(logger, toggle, null);
        }

        public static void FeatureTagAlreadyExist(ILogger logger, string feature, string tag)
        {
            _featureTagAlreadyExist(logger, feature, tag, null);
        }
        public static void FeatureTagNotExist(ILogger logger, string feature, string tag)
        {
            _featureTagNotExist(logger, feature, tag, null);
        }

        public static void ToggleTypeAlreadyExist(ILogger logger, string toggleType, string feature)
        {
            _toggleAlreadyExist(logger, toggleType, feature, null);
        }

        public static void ExecutingCommand(ILogger logger, string commandName)
        {
            _executingCommand(logger, commandName, null);
        }
        public static void ExecutedCommand(ILogger logger, string commandName)
        {
            _executedCommand(logger, commandName, null);
        }

        public static void AuthorizationFail(ILogger logger, string subjectId)
        {
            _authorizationFail(logger, subjectId, null);
        }

        public static void AuthorizationRequiredPermissionFail(ILogger logger, string subjectId, string permission)
        {
            _authorizationPermissionFail(logger, subjectId, permission, null);
        }

        public static void AuthorizationFailClaimIsNotPressent(ILogger logger, string claimType)
        {
            _authorizationFailClaimIsNotPresent(logger, claimType, null);
        }

        public static void SubjectIdAlreadyExist(ILogger logger, string subjectId)
        {
            _subjectIdAlreadyExist(logger, subjectId, null);
        }

        public static void MyIsNotAuthorized(ILogger logger, string subjectId)
        {
            _subjectIdAlreadyExist(logger, subjectId, null);
        }
        public static void SubjectIdDoesNotExist(ILogger logger, string subjectId)
        {
            _subjectIdDoesNotExist(logger, subjectId, null);
        }

        public static void RingAlreadyExist(ILogger logger, string ring, string product)
        {
            _ringAlreadyExist(logger, ring, product, null);
        }

        public static void RingNotExist(ILogger logger, string ring, string product)
        {
            _ringNotExist(logger, ring, product, null);
        }

        public static void CantDeleteDefaultRing(ILogger logger, string ring, string product)
        {
            _cantDeleteDefaultRing(logger, ring, product, null);
        }

        private static readonly Action<ILogger, string, Exception> _apiKeyAlreadyExist = LoggerMessage.Define<string>(
            LogLevel.Warning,
            EventIds.ApiKeyAlreadyExist,
            "The ApiKey with name {apiKeyName} already exist in the store and can't be created.");
        private static readonly Action<ILogger, string, Exception> _productAlreadyExist = LoggerMessage.Define<string>(
           LogLevel.Warning,
           EventIds.ProductAlreadyExist,
           "The product with name {productName} already exist in the store and can't be created.");
        private static readonly Action<ILogger, string, Exception> _featureNameAlreadyExist = LoggerMessage.Define<string>(
            LogLevel.Warning,
            EventIds.FeatureAlreadyExist,
            "A feature with name {featureName} already exist in the store and can't be created.");
        private static readonly Action<ILogger, string, Exception> _apiKeyNotExist = LoggerMessage.Define<string>(
            LogLevel.Warning,
            EventIds.ApiKeyNotExist,
            "The ApiKey with identifier {apiKeyId} does not exist in database and can't be deleted.");
        private static readonly Action<ILogger, string, Exception> _productNotExist = LoggerMessage.Define<string>(
            LogLevel.Warning,
            EventIds.ProductNotExist,
            "The product with identifier {product} does not exist in database.");
        private static readonly Action<ILogger, string, Exception> _featureNotExist = LoggerMessage.Define<string>(
           LogLevel.Warning,
           EventIds.FeatureNotExist,
           "The feature with identifier {feature} does not exist in database.");
        private static readonly Action<ILogger, string, Exception> _toggleNotExist = LoggerMessage.Define<string>(
          LogLevel.Warning,
          EventIds.ToggleNotExist,
          "The toggle with identifier {toggle} does not exist in database.");
        private static readonly Action<ILogger, string, string, Exception> _toggleAlreadyExist = LoggerMessage.Define<string, string>(
           LogLevel.Warning,
           EventIds.ToggleAlreadyExist,
           "A toggle with type {toggleType} already exist on feature {feature} and can't be added.");
        private static readonly Action<ILogger, string, string, Exception> _featureTagNotExist = LoggerMessage.Define<string, string>(
          LogLevel.Warning,
          EventIds.FeatureTagNotExist,
          "The feature association between feature {feature} and tag {tag} does not exist.");
        private static readonly Action<ILogger, string, string, Exception> _featureTagAlreadyExist = LoggerMessage.Define<string, string>(
          LogLevel.Warning,
          EventIds.FeatureAlreadyExist,
          "The feature with id {featureId} already have association with tag {tag}.");
        private static readonly Action<ILogger, string, Exception> _executingCommand = LoggerMessage.Define<string>(
            LogLevel.Debug,
            EventIds.ExecutingCommand,
            "Executing command with name {commandName}.");
        private static readonly Action<ILogger, string, Exception> _executedCommand = LoggerMessage.Define<string>(
            LogLevel.Debug,
            EventIds.ExecutedCommand,
            "Executed  command with name {commandName}.");
        private static readonly Action<ILogger, string, Exception> _authorizationFail = LoggerMessage.Define<string>(
           LogLevel.Warning,
           EventIds.AuthorizationFailed,
           "Authorization failed for user {subjectId}.");
        private static readonly Action<ILogger, string, string, Exception> _authorizationPermissionFail = LoggerMessage.Define<string, string>(
           LogLevel.Warning,
           EventIds.AuthorizationPermissionFailed,
           "Authorization failed for user {subjectId} with required permission {permission}.");
        private static readonly Action<ILogger, string, Exception> _authorizationFailClaimIsNotPresent = LoggerMessage.Define<string>(
           LogLevel.Error,
           EventIds.AuthorizationFailedClaimIsNotPresent,
           "Authorization failed because the selected claim {claimType} is not present.");
        private static readonly Action<ILogger, string, Exception> _subjectIdAlreadyExist = LoggerMessage.Define<string>(
           LogLevel.Warning,
           EventIds.SubjectIdAlreadyExist,
           "The subject id {subjectId} already exist on the store.");
        private static readonly Action<ILogger, string, Exception> _myIsNotAuthorized = LoggerMessage.Define<string>(
           LogLevel.Warning,
           EventIds.SubjectIdAlreadyExist,
           "The current user with subjectId {subjectId} is not authorized on the Esquio UI.");
        private static readonly Action<ILogger, string, Exception> _subjectIdDoesNotExist = LoggerMessage.Define<string>(
           LogLevel.Warning,
           EventIds.SubjectIdDoesNotExist,
           "The subject id {subjectId} does not exist on the store.");
        private static readonly Action<ILogger, string, string, Exception> _ringAlreadyExist = LoggerMessage.Define<string, string>(
          LogLevel.Warning,
          EventIds.RingAlreadyExist,
          "The ring with name {ring} already exist for product {product} in the store and can't be created.");
        private static readonly Action<ILogger, string, string, Exception> _ringNotExist = LoggerMessage.Define<string, string>(
          LogLevel.Warning,
          EventIds.RingNotExist,
          "The ring with name {ring} does not exist for product {product} in the store.");
        private static readonly Action<ILogger, string, string, Exception> _cantDeleteDefaultRing = LoggerMessage.Define<string, string>(
          LogLevel.Warning,
          EventIds.CantDeleteDefaultRing,
          "The ring with name {ring} is default ring for product {product} and can't be deleted.");
    }
}

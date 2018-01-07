﻿using System.Threading.Tasks;
using Certes.Acme.Resource;

namespace Certes.Acme
{
    /// <summary>
    /// 
    /// </summary>
    public interface IChallengeContext : IResourceContext<AuthorizationIdentifierChallenge>
    {
        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        string Type { get; }

        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        string Token {get;}

        /// <summary>
        /// Acknowledges the ACME server the challenge is ready for validation
        /// </summary>
        /// <returns>The challenge.</returns>
        Task<AuthorizationIdentifierChallenge> Validate();
    }
}
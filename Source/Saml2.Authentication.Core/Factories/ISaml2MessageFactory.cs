﻿using dk.nita.saml20;

namespace Saml2.Authentication.Core.Factories
{
    public interface ISaml2MessageFactory
    {
        Saml20AuthnRequest CreateAuthnRequest(string authnRequestId);
    }
}
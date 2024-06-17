using System;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Core.Environments;
using UnityEngine;

public class UnityServicesInitializer: MonoBehaviour
{
    public string environment = "production";
 
    async void Start() {
        try
        {
            var options = new InitializationOptions();
            options.SetEnvironmentName(environment);
            await UnityServices.InitializeAsync(options);
            await AuthenticationService.Instance.SignInAnonymouslyAsync();
        }
        catch (Exception exception) {
            // An error occurred during initialization.
        }
    }
}

// File: Program.cs (ASP.NET Core 6+ Minimal API Template)

using CompositeLibrary.SimpleSample;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// ----------------------------------------------------
// THE COMPOSITION ROOT: Registering Services (Wiring Up)
// ----------------------------------------------------

var builder = WebApplication.CreateBuilder(args);

// Access the IoC Container (IServiceCollection)
var services = builder.Services;

// Rule: Register the High-Level Module
// PaymentProcessor depends on IPaymentGateway, so the container will find and inject that dependency.
services.AddTransient<PaymentProcessor>();

// Rule: Register the Abstraction with its Concrete Detail
// This is the critical Composition Root step. We are choosing the concrete implementation.
// services.AddTransient<IPaymentGateway, CreditCardCharger>(); // Option 1
services.AddTransient<IPaymentGateway, PayPalGateway>();       // Option 2 (The current choice)

// We have defined the entire object graph for the application here.

var app = builder.Build();

// ----------------------------------------------------
// APPLICATION RUNTIME (Consuming the Object Graph)
// ----------------------------------------------------

// Example 1: Resolving a Controller/Endpoint Dependency
app.MapGet("/process-order", (PaymentProcessor processor) =>
{
    // The framework (via the IoC container) automatically instantiates PaymentProcessor 
    // and injects the configured IPaymentGateway (PayPalGateway in this case).

    // The "processor" instance is fully wired up!
    processor.HandleOrder(50.00m);

    return Results.Ok("Order processing initiated.");
});

// Example 2: Resolving a service manually (for demonstration)
using (var scope = app.Services.CreateScope())
{
    // Retrieve the fully wired PaymentProcessor instance from the container
    var processor = scope.ServiceProvider.GetRequiredService<PaymentProcessor>();

    Console.WriteLine("\n--- Manual Composition Root Test ---");
    processor.HandleOrder(120.50m);
    Console.WriteLine("--------------------------------------");
}


app.Run();

/*
Example Console Output (when hitting the /process-order endpoint):

[High-Level] Payment Processor starting order for $50.00
[Detail] Using PayPal Gateway: Processing $50.00
[High-Level] Order successfully processed.

--- Manual Composition Root Test ---
[High-Level] Payment Processor starting order for $120.50
[Detail] Using PayPal Gateway: Processing $120.50
[High-Level] Order successfully processed.
--------------------------------------

Summary of the Composition Root
-----
Component: IPaymentGateway
Role in DIP: Abstraction (The Contract)
Role in Composition Root: Registered as the Service Type to be requested.
-----
Component: PayPalGateway
Role in DIP: Detail (The Implementation)
Role in Composition Root: Registered as the Implementation Type to fulfill the request.
-----
Component: PaymentProcessor
Role in DIP: High-Level Module (The Consumer)
Role in Composition Root: Registered so the container can resolve its dependencies (IPaymentGateway).

---IoC----
When the framework/application requests a PaymentProcessor, the IoC Container:
a. Reads the PaymentProcessor's constructor.
b. Sees it needs an IPaymentGateway.
c. Checks its registered map (from step 1).
d. Creates the PayPalGateway instance.
e. *Injects* the PayPalGateway into the PaymentProcessor constructor.

------Meaning of Inversion------
1. Inversion of Dependency (DIP): The dependency is "inverted" because the dependency graph now points toward the stable abstraction 
instead of toward the volatile detail. This keeps the important business logic stable and isolated from implementation changes.
2.Inversion of Control (IoC): The control over the flow and the lifecycle of the objects has been inverted. The application code 
no longer dictates when and how to instantiate its dependencies; it merely declares what dependencies it needs. 
The IoC Container takes control of the rest.
------------
*/
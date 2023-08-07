namespace BoldSign.Examples
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using BoldSign.Api;
    using BoldSign.Model.Webhook;
    using Microsoft.AspNetCore.Mvc;

    public class WebhookExampleController : Controller
    {
        [HttpPost]
        [IgnoreAntiforgeryToken]
        public async Task<IActionResult> Webhook()
        {
            var sr = new StreamReader(this.Request.Body);

            var json = await sr.ReadToEndAsync();

            if (this.Request.Headers[WebhookUtility.BoldSignEventHeader] == "Verification")
            {
                return this.Ok();
            }

            var boldSignSigningSecret = Environment.GetEnvironmentVariable("BoldSignSigningSecret");

            try
            {
                WebhookUtility.ValidateSignature(
                    json,
                    this.Request.Headers[WebhookUtility.BoldSignSignatureHeader],
                    boldSignSigningSecret);
            }
            catch (BoldSignSignatureException ex)
            {
                Console.WriteLine(ex);

                return this.Forbid();
            }

            var eventPayload = WebhookUtility.ParseEvent(json);

            switch (eventPayload.Event.EventType)
            {
                // if its a document event, cast as DocumentEvent
                case WebHookEventType.Declined:
                    var documentEvent = eventPayload.Data as DocumentEvent;

                    break;

                // if its a sender identity event, cast as SenderIdentityEvent
                case WebHookEventType.SenderIdentityUpdated:
                    var senderIdentityEvent = eventPayload.Data as SenderIdentityEvent;

                    break;
            }

            return this.Ok();
        }
    }
}
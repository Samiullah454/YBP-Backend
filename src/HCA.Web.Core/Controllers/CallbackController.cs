using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.MultiTenancy;
using Abp.Runtime.Security;
using Abp.UI;
using HCA.Authentication.External;
using HCA.Authentication.JwtBearer;
using HCA.Authorization;
using HCA.Authorization.Users;
using HCA.Models.TokenAuth;
using HCA.MultiTenancy;
using Newtonsoft.Json;
using Bandwidth.Standard.Messaging.Models;
using System.Text;
using System.IO;
using HCA.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using Abp.Dependency;
using HCA.Users;
using Abp.Runtime.Session;
using Abp.Domain.Repositories;

namespace HCA.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CallbackController : HCAControllerBase
    {
        private readonly IHubContext<ChatHubCore> _hubContext;
        private readonly IIocResolver _iocResolver;
        private readonly IAbpSession _abpSession;
        private readonly IRepository<User, long> _userRepository;

        private readonly IRepository<Tenant, int> _tenantRepository;

        public CallbackController(
            IHubContext<ChatHubCore> hubContext,
            IIocResolver iocResolver,
            IAbpSession abpSession,
            IRepository<User, long> userRepository,
            IRepository<Tenant, int> tenantRepository
           )
        {
            _iocResolver = iocResolver;
            _hubContext = hubContext;
            _abpSession = abpSession;
            _userRepository = userRepository;
            _tenantRepository = tenantRepository;
        }

        [HttpPost]
        public async Task<IActionResult> MessagesInbound()
        {
            try
            {
                var reader = new StreamReader(Request.Body, Encoding.UTF8);
                var body = await reader.ReadToEndAsync();

                var message = JsonConvert.DeserializeObject<IEnumerable<BandwidthCallbackMessage>>(body).First();

                //MessagCls message = new MessagCls();
                //message.From = "+4802759047";
                //message.To = new List<string>() { "+14802407200" };
                //message.Time = DateTime.UtcNow.ToString();
                //message.Direction = "Inbound";
                //message.Text = "Iqbal";
                //message.Type = "message-received";
                switch (message.Type)
                {
                    case "message-received":
                        var tenant = _tenantRepository.GetAll().ToList();
                        //var tenantId = tenant.FirstOrDefault(x => x.MobileNumber == message.To).Id;
                        //using (CurrentUnitOfWork.SetTenantId(tenantId))
                        //{
                        //    var contactService = _iocResolver.Resolve<Contacts.ContactAppService>();
                        //    var user = _userRepository.GetAll().ToList();
                        //    var userId = user.FirstOrDefault(x => x.PhoneNumber == "+14802407200").Id;
                        //    var Contacts = await contactService.GetAllContacts();
                        //    var ContactTobeSaved = Contacts.FirstOrDefault(x => x.MobileNumber == message.Message.From);

                        //    if (ContactTobeSaved == null)
                        //    {
                        //        ContactDto contactobj = new ContactDto();
                        //        contactobj.about = "Unsaved Contact";
                        //        contactobj.role = "unsaved";
                        //        contactobj.FirstName = "Unsaved";
                        //        contactobj.LastName = "Contact";
                        //        contactobj.MobileNumber = message.Message.From;
                        //        contactobj.fullName = message.Message.From;
                        //        contactobj.status = "online";
                        //        contactobj.avatar = "assets/images/avatars/2.png";
                        //        await contactService.CreateAsync(contactobj);
                        //        await CurrentUnitOfWork.SaveChangesAsync();
                        //    }

                        //    Contacts = await contactService.GetAllContacts();
                        //    ContactTobeSaved = Contacts.FirstOrDefault(x => x.MobileNumber == message.Message.From);

                        //    var chatwithcontact = _chatRepository.GetAllIncluding(x => x.chatDetails).ToList().Where(x => x.userId == ContactTobeSaved.Id);
                        //    ChatDTO chatDto = new ChatDTO();

                        //    // Initialize the chatDto properties
                        //    chatDto.unseenMsgs = 1;
                        //    chatDto.userId = ContactTobeSaved.Id;
                        //    ChatDetailDto detail = new ChatDetailDto();
                        //    detail.time = DateTime.Now;

                        //    if (chatwithcontact.Count() == 0)
                        //    {
                        //        // If a chat with the user does not exist, create a new chat entity
                        //        chatDto.Id = 0;
                        //        detail.message = message.Message.Text;
                        //        detail.senderId = ContactTobeSaved.Id;
                        //        detail.chatId = 0;
                        //        chatDto.chatDetails.Add(detail);

                        //        // Map the chatDto to a Chat entity
                        //        var chat = ObjectMapper.Map<Chat.Chat>(chatDto);

                        //        // Insert the new chat entity
                        //        _chatRepository.Insert(chat);
                        //    }
                        //    else
                        //    {
                        //        // If a chat with the user already exists, update the existing chat entity
                        //        chatwithcontact.First().unseenMsgs = chatwithcontact.First().unseenMsgs + 1;
                        //        ChatDetail det = new ChatDetail();
                        //        det.time = DateTime.Now;
                        //        det.message = message.Message.Text;
                        //        det.senderId = ContactTobeSaved.Id;
                        //        det.chatId = chatwithcontact.First().Id;
                        //        chatwithcontact.First().chatDetails.Add(det);
                        //        _chatRepository.Update(chatwithcontact.First());
                        //    }

                        //    // Save changes to the database
                        //    await CurrentUnitOfWork.SaveChangesAsync();

                        //    var notificationService = _iocResolver.Resolve<Notification.NotifcationsAppService>();
                        //    Notification.Dto.NotificationsDto notificationsDto = new Notification.Dto.NotificationsDto();
                        //    notificationsDto.Title = "New Message Recieved from " + message.Message.From;
                        //    notificationsDto.Detail = message.Message.Text;
                        //    notificationsDto.IsRead = false;
                        //    notificationsDto.FromUser = 0;
                        //    notificationsDto.ToUser = int.Parse(userId.ToString());
                        //    await notificationService.CreateAsync(notificationsDto);
                        //    await CurrentUnitOfWork.SaveChangesAsync();
                        //    await _hubContext.Clients.All.SendAsync("ReceiveMessage", notificationsDto.ToUser, notificationsDto.Detail);
                        //}

                        var matchingTenants = tenant.ToList();

                        foreach (var matchingTenant in matchingTenants)
                        {
                            using (CurrentUnitOfWork.SetTenantId(matchingTenant.Id))
                            {
                                var user = _userRepository.GetAll().ToList();
                                var userId = user.FirstOrDefault(x => x.PhoneNumber == "+14802407200").Id;
                                // Save changes to the database
                                await CurrentUnitOfWork.SaveChangesAsync();

                                var notificationService = _iocResolver.Resolve<Notification.NotifcationsAppService>();
                                Notification.Dto.NotificationsDto notificationsDto = new Notification.Dto.NotificationsDto();
                                notificationsDto.Title = "New Message Recieved from " + message.Message.From;
                                notificationsDto.Detail = message.Message.Text;
                                notificationsDto.IsRead = false;
                                notificationsDto.FromUser = 0;
                                notificationsDto.ToUser = int.Parse(userId.ToString());
                                await notificationService.CreateAsync(notificationsDto);
                                await CurrentUnitOfWork.SaveChangesAsync();
                                await _hubContext.Clients.All.SendAsync("ReceiveMessage", notificationsDto.ToUser, notificationsDto.Detail);
                            }
                        }
                        break;

                    default:
                        break;
                }
                return Ok("Message sent successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error sending message: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult> MessagesOutbound()
        {
            var reader = new StreamReader(Request.Body, Encoding.UTF8);
            var body = await reader.ReadToEndAsync();

            var message = JsonConvert.DeserializeObject<IEnumerable<BandwidthCallbackMessage>>(body).First();

            switch (message.Type)
            {
                case "message-delivered":
                    //_logger.LogInformation("Message delivered from Bandwidth's network.");
                    break;

                case "message-sending":
                    //_logger.LogInformation("message-sending type is only for MMS.");
                    break;

                case "message-failed":
                    //_logger.LogInformation("For MMS and Group Messages, you will only receive this callback if you have enabled delivery receipts on MMS.");
                    break;

                default:
                    //_logger.LogInformation("Message type does not match endpoint. This endpoint is used for outbound status callbacks only.\n      Inbound message callbacks should be sent to /callbacks/inbound/messaging.");
                    break;
            }

            return new OkResult();
        }

        //[HttpPost("callInitiatedCallback")]
        //public async Task<ActionResult> CallInitiatedCallback()
        //{
        //    var unavailableSpeakSentence = new SpeakSentence
        //    {
        //        Sentence = "You have reached Vandelay Industries, Kal Varnsen is unavailable at this time."
        //    };

        //    var messageSpeakSentence = new SpeakSentence
        //    {
        //        Sentence = "At the tone, please record your message, when you have finished recording, you may hang up."
        //    };

        //    var playAudio = new PlayAudio
        //    {
        //        Url = "/files/tone"
        //    };

        //    var record = new Record
        //    {
        //        RecordingAvailableUrl = "/callbacks/recordingAvailableCallback"
        //    };

        //    var response = new Response(
        //        unavailableSpeakSentence,
        //        messageSpeakSentence,
        //        playAudio,
        //        record
        //    );

        //    return new OkObjectResult(response.ToBXML());
        //}
        //[HttpPost("CallStatus")]
        //public async Task<ActionResult> CallStatus()
        //{
        //    var unavailableSpeakSentence = new SpeakSentence
        //    {
        //        Sentence = "You have reached Vandelay Industries, Kal Varnsen is unavailable at this time."
        //    };

        //    var messageSpeakSentence = new SpeakSentence
        //    {
        //        Sentence = "At the tone, please record your message, when you have finished recording, you may hang up."
        //    };

        //    var playAudio = new PlayAudio
        //    {
        //        Url = "/files/tone"
        //    };

        //    var record = new Record
        //    {
        //        RecordingAvailableUrl = "/callbacks/recordingAvailableCallback"
        //    };

        //    var response = new Response(
        //        unavailableSpeakSentence,
        //        messageSpeakSentence,
        //        playAudio,
        //        record
        //    );

        //    return new OkObjectResult(response.ToBXML());
        //}

        //[HttpPost("GetWebRtcToken")]
        //public async Task<IActionResult> GetWebRtcToken()
        //{
        //    var BWConfigs = _context.Configurations.First();
        //    var FromNumber = _context.Contact.First(x => x.IsFrom == true);
        //    var username = BWConfigs.BWUserName;
        //    var password = BWConfigs.BWPassword;
        //    var accountId = BWConfigs.BWAccoundId;
        //    var applicationId = "8c988c44-567a-49c4-a876-e485eff2f189";
        //    var to = "+16232268966";
        //    var from = FromNumber.Phone;
        //    var baseUrl = "https://www.hca.hybriditservices.com";
        //    var answerUrl = string.Concat(baseUrl, "/callbacks/callInitiatedCallback");

        //    var client = new BandwidthClient.Builder()
        //        .WebRtcBasicAuthCredentials(username, password)
        //        .Build();

        //    var request = new CreateCallRequest()
        //    {
        //        ApplicationId = applicationId,
        //        To = to,
        //        From = from,
        //        AnswerUrl = answerUrl
        //    };

        //    try
        //    {
        //        var response = await client.WebRtc.APIController.CreateSessionAsync(accountId);
        //        return Json(new
        //        {
        //            status = response
        //        });
        //    }
        //    catch (ApiException e)
        //    {
        //        return Json(new
        //        {
        //            status = "Connected"
        //        });
        //    }

        //}

        private IActionResult Json(object p)
        {
            throw new NotImplementedException();
        }
    }
}

public class MessagCls
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id
    {
        get;
        set;
    }

    [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
    public string Owner
    {
        get;
        set;
    }

    [JsonProperty("applicationId", NullValueHandling = NullValueHandling.Ignore)]
    public string ApplicationId
    {
        get;
        set;
    }

    [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
    public string Time
    {
        get;
        set;
    }

    [JsonProperty("segmentCount", NullValueHandling = NullValueHandling.Ignore)]
    public int? SegmentCount
    {
        get;
        set;
    }

    [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
    public string Direction
    {
        get;
        set;
    }

    [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> To
    {
        get;
        set;
    }

    [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
    public string From
    {
        get;
        set;
    }

    [JsonProperty("media", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Media
    {
        get;
        set;
    }

    [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
    public string Text
    {
        get;
        set;
    }

    [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
    public string Tag
    {
        get;
        set;
    }

    [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
    public string Priority
    {
        get;
        set;
    }

    [JsonProperty("Type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type
    {
        get;
        set;
    }
}
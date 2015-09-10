using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.EntityParser;
using Newtonsoft.Json;
using PetaPoco;

namespace MixERP.Net.Api.Core
{
    /// <summary>
    ///     Provides a direct HTTP access to perform various tasks such as adding, editing, and removing Social Networks.
    /// </summary>
    [RoutePrefix("api/v1.5/core/social-network")]
    public class SocialNetworkController : ApiController
    {
        /// <summary>
        ///     The SocialNetwork data context.
        /// </summary>
        private readonly MixERP.Net.Schemas.Core.Data.SocialNetwork SocialNetworkContext;

        public SocialNetworkController()
        {
            this.LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.Catalog = AppUsers.GetCurrentUserDB();

            this.SocialNetworkContext = new MixERP.Net.Schemas.Core.Data.SocialNetwork
            {
                Catalog = this.Catalog,
                LoginId = this.LoginId
            };
        }

        public long LoginId { get; }
        public int UserId { get; private set; }
        public int OfficeId { get; private set; }
        public string Catalog { get; }

        /// <summary>
        ///     Counts the number of social networks.
        /// </summary>
        /// <returns>Returns the count of the social networks.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("count")]
        [Route("~/api/core/social-network/count")]
        public long Count()
        {
            try
            {
                return this.SocialNetworkContext.Count();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Returns an instance of social network.
        /// </summary>
        /// <param name="socialNetworkName">Enter SocialNetworkName to search for.</param>
        /// <returns></returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("{socialNetworkName}")]
        [Route("~/api/core/social-network/{socialNetworkName}")]
        public MixERP.Net.Entities.Core.SocialNetwork Get(string socialNetworkName)
        {
            try
            {
                return this.SocialNetworkContext.Get(socialNetworkName);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a paginated collection containing 25 social networks on each page, sorted by the property SocialNetworkName.
        /// </summary>
        /// <returns>Returns the first page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("")]
        [Route("~/api/core/social-network")]
        public IEnumerable<MixERP.Net.Entities.Core.SocialNetwork> GetPagedResult()
        {
            try
            {
                return this.SocialNetworkContext.GetPagedResult();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a paginated collection containing 25 social networks on each page, sorted by the property SocialNetworkName.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <returns>Returns the requested page from the collection.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("page/{pageNumber}")]
        [Route("~/api/core/social-network/page/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.SocialNetwork> GetPagedResult(long pageNumber)
        {
            try
            {
                return this.SocialNetworkContext.GetPagedResult(pageNumber);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Creates a filtered and paginated collection containing 25 social networks on each page, sorted by the property SocialNetworkName.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the resultset.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns the requested page from the collection using the supplied filters.</returns>
        [AcceptVerbs("POST")]
        [Route("get-where/{pageNumber}")]
        [Route("~/api/core/social-network/get-where/{pageNumber}")]
        public IEnumerable<MixERP.Net.Entities.Core.SocialNetwork> GetWhere(long pageNumber, [FromBody]dynamic filters)
        {
            try
            {
                List<EntityParser.Filter> f = JsonConvert.DeserializeObject<List<EntityParser.Filter>>(filters);
                return this.SocialNetworkContext.GetWhere(pageNumber, f);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Displayfield is a lightweight key/value collection of social networks.
        /// </summary>
        /// <returns>Returns an enumerable key/value collection of social networks.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("display-fields")]
        [Route("~/api/core/social-network/display-fields")]
        public IEnumerable<DisplayField> GetDisplayFields()
        {
            try
            {
                return this.SocialNetworkContext.GetDisplayFields();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     A custom field is a user defined field for social networks.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection of social networks.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("custom-fields")]
        [Route("~/api/core/social-network/custom-fields")]
        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            try
            {
                return this.SocialNetworkContext.GetCustomFields();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Adds your instance of Account class.
        /// </summary>
        /// <param name="socialNetwork">Your instance of social networks class to add.</param>
        [AcceptVerbs("POST")]
        [Route("add/{socialNetwork}")]
        [Route("~/api/core/social-network/add/{socialNetwork}")]
        public void Add(MixERP.Net.Entities.Core.SocialNetwork socialNetwork)
        {
            if (socialNetwork == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SocialNetworkContext.Add(socialNetwork);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Edits existing record with your instance of Account class.
        /// </summary>
        /// <param name="socialNetwork">Your instance of Account class to edit.</param>
        /// <param name="socialNetworkName">Enter the value for SocialNetworkName in order to find and edit the existing record.</param>
        [AcceptVerbs("PUT")]
        [Route("edit/{socialNetworkName}/{socialNetwork}")]
        [Route("~/api/core/social-network/edit/{socialNetworkName}/{socialNetwork}")]
        public void Edit(string socialNetworkName, MixERP.Net.Entities.Core.SocialNetwork socialNetwork)
        {
            if (socialNetwork == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed));
            }

            try
            {
                this.SocialNetworkContext.Update(socialNetwork, socialNetworkName);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }

        /// <summary>
        ///     Deletes an existing instance of Account class via SocialNetworkName.
        /// </summary>
        /// <param name="socialNetworkName">Enter the value for SocialNetworkName in order to find and delete the existing record.</param>
        [AcceptVerbs("DELETE")]
        [Route("delete/{socialNetworkName}")]
        [Route("~/api/core/social-network/delete/{socialNetworkName}")]
        public void Delete(string socialNetworkName)
        {
            try
            {
                this.SocialNetworkContext.Delete(socialNetworkName);
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }


    }
}
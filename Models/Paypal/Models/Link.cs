namespace PayPal.NET.Models.Responses
{
    public class Link
    {
        /// <summary>
        /// The complete target URL. To make the related call, combine the method with this URI Template-formatted link. For pre-processing, include the $, (, and ) characters. The href is the key HATEOAS component that links a completed call with a subsequent call.
        /// </summary>
        public string href { get; set; }
        /// <summary>
        /// The link relation type, which serves as an ID for a link that unambiguously describes the semantics of the link. See Link Relation
        /// </summary>
        public string rel { get; set; }
        /// <summary>
        /// The HTTP method required to make the related call.

        /// Possible values: GET,POST,PUT,DELETE,HEAD,CONNECT,OPTIONS,PATCH.
        /// </summary>
        public string method { get; set; }
    }
}

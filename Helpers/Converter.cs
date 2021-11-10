using Models;

namespace Helpers {
    public static class Converter {
        public static Lead Convert(ZendeskSell.Leads.LeadResponse leadResponse) =>
            new Lead() {
                ID = leadResponse.ID,
                Link = leadResponse.GetLink(),
                CreatorID = leadResponse.CreatorID,
                CreatedAt = leadResponse.CreatedAt.ToString(),
                UpdatedAt = leadResponse.UpdatedAt.ToString(),

                OwnerID = leadResponse.OwnerID,
                Name = string.Join(' ', leadResponse.FirstName, leadResponse.LastName),
                FirstName = leadResponse.FirstName,
                LastName = leadResponse.LastName,
                OrganizationName = leadResponse.OrganizationName,
                Status = leadResponse.Status,
                SourceID = leadResponse.SourceID,
                Title = leadResponse.Title,
                Description = leadResponse.Description,
                Industry = leadResponse.Industry,
                Website = leadResponse.Website,
                Email = leadResponse.Email,
                Phone = leadResponse.Phone,
                Mobile = leadResponse.Mobile,
                Fax = leadResponse.Fax,
                Twitter = leadResponse.Twitter,
                Facebook = leadResponse.Facebook,
                LinkedIn = leadResponse.LinkedIn,
                Skype = leadResponse.Skype,
                Address = new Address(leadResponse.Address),
                Tags = leadResponse.Tags,
                CustomFields = leadResponse.CustomFields,
            };
        public static ZendeskSell.Leads.LeadRequest Convert(Lead lead) =>
            new ZendeskSell.Leads.LeadRequest() {
                OwnerID = lead.OwnerID,
                FirstName = lead.FirstName,
                LastName = lead.LastName,
                OrganizationName = lead.OrganizationName,
                Status = lead.Status,
                SourceID = lead.SourceID,
                Title = lead.Title,
                Description = lead.Description,
                Industry = lead.Industry,
                Website = lead.Website,
                Email = lead.Email,
                Phone = lead.Phone,
                Mobile = lead.Mobile,
                Fax = lead.Fax,
                Twitter = lead.Twitter,
                Facebook = lead.Facebook,
                LinkedIn = lead.LinkedIn,
                Skype = lead.Skype,
                Address = lead.Address,
                Tags = lead.Tags,
                CustomFields = lead.CustomFields,
            };

        public static Contact Convert(ZendeskSell.Contacts.ContactResponse contactResponse) =>
            new Contact() {
                ID = contactResponse.ID,
                Link = contactResponse.GetLink(),
                CreatorID = contactResponse.CreatorID,
                CreatedAt = contactResponse.CreatedAt.ToString(),
                UpdatedAt = contactResponse.UpdatedAt.ToString(),

                OwnerID = contactResponse.OwnerID,
                Name = contactResponse.Name,
                FirstName = contactResponse.FirstName,
                LastName = contactResponse.LastName,
                IsOrganization = contactResponse.IsOrganization,
                ContactID = contactResponse.ContactID,
                ParentOrganizationID = contactResponse.ParentOrganizationID,
                CustomerStatus = contactResponse.CustomerStatus,
                ProspectStatus = contactResponse.ProspectStatus,
                Title = contactResponse.Title,
                Description = contactResponse.Description,
                Industry = contactResponse.Industry,
                Website = contactResponse.Website,
                Email = contactResponse.Email,
                Phone = contactResponse.Phone,
                Mobile = contactResponse.Mobile,
                Fax = contactResponse.Fax,
                Twitter = contactResponse.Twitter,
                Facebook = contactResponse.Facebook,
                LinkedIn = contactResponse.Linkedin,
                Skype = contactResponse.Skype,
                Address = new Address(contactResponse.Address),
                BillingAddress = new Address(contactResponse.BillingAddress),
                ShippingAddress = new Address(contactResponse.ShippingAddress),
                Tags = contactResponse.Tags,
                CustomFields = contactResponse.CustomFields,
            };
        public static ZendeskSell.Contacts.ContactRequest Convert(Contact contact) =>
            new ZendeskSell.Contacts.ContactRequest() {
                OwnerID = contact.OwnerID,
                Name = contact.Name,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                IsOrganization = contact.IsOrganization,
                ContactID = contact.ContactID,
                ParentOrganizationID = contact.ParentOrganizationID,
                CustomerStatus = contact.CustomerStatus,
                ProspectStatus = contact.ProspectStatus,
                Title = contact.Title,
                Description = contact.Description,
                Industry = contact.Industry,
                Website = contact.Website,
                Email = contact.Email,
                Phone = contact.Phone,
                Mobile = contact.Mobile,
                Fax = contact.Fax,
                Twitter = contact.Twitter,
                Facebook = contact.Facebook,
                Linkedin = contact.LinkedIn,
                Skype = contact.Skype,
                Address = contact.Address,
                BillingAddress = contact.BillingAddress,
                ShippingAddress = contact.ShippingAddress,
                Tags = contact.Tags,
                CustomFields = contact.CustomFields,
            };

        public static Deal Convert(ZendeskSell.Deals.DealResponse dealResponse) =>
            new Deal() {
                ID = dealResponse.ID,
                Link = dealResponse.GetLink(),
                CreatorID = dealResponse.CreatorID,
                CreatedAt = dealResponse.CreatedAt.ToString(),
                UpdatedAt = dealResponse.UpdatedAt.ToString(),
                LastActivityAt = dealResponse.LastActivityAt.ToString(),
                LastStageChangeByID = dealResponse.LastStageChangeByID,
                DropboxEmail = dealResponse.DropboxEmail,
                OrganizationID = dealResponse.OrganizationID,

                OwnerID = dealResponse.OwnerID,
                Name = dealResponse.Name,
                Value = dealResponse.Value,
                ContactID = dealResponse.ContactID,
                Currency = dealResponse.Currency,
                Hot = dealResponse.Hot,
                StageID = dealResponse.StageID,
                LastStageChangeAt = dealResponse.LastStageChangeAt.ToString(),
                AddedAt = dealResponse.AddedAt.ToString(),
                SourceID = dealResponse.SourceID,
                LossReasonID = dealResponse.LossReasonID,
                UnqualifiedReasonID = dealResponse.UnqualifiedReasonID,
                EstimatedCloseDate = dealResponse.EstimatedCloseDate.ToString(),
                CustomizedWinLikelihood = dealResponse.CustomizedWinLikelihood,
                Tags = dealResponse.Tags,
                CustomFields = dealResponse.CustomFields,
            };
        public static ZendeskSell.Deals.DealRequest Convert(Deal deal) =>
            new ZendeskSell.Deals.DealRequest() {
                OwnerID = deal.OwnerID,
                Name = deal.Name,
                Value = deal.Value,
                ContactID = deal.ContactID,
                Currency = deal.Currency,
                Hot = deal.Hot,
                StageID = deal.StageID,
                LastStageChangeAt = string.IsNullOrWhiteSpace(deal.LastStageChangeAt) ? (System.DateTimeOffset?)null : System.DateTimeOffset.Parse(deal.LastStageChangeAt),
                AddedAt = string.IsNullOrWhiteSpace(deal.AddedAt) ? (System.DateTimeOffset?)null : System.DateTimeOffset.Parse(deal.AddedAt),
                SourceID = deal.SourceID,
                LossReasonID = deal.LossReasonID,
                UnqualifiedReasonID = deal.UnqualifiedReasonID,
                EstimatedCloseDate = string.IsNullOrWhiteSpace(deal.EstimatedCloseDate) ? (System.DateTimeOffset?)null : System.DateTimeOffset.Parse(deal.EstimatedCloseDate),
                CustomizedWinLikelihood = deal.CustomizedWinLikelihood,
                Tags = deal.Tags,
                CustomFields = deal.CustomFields,
            };
    }
}

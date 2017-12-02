---
title: Sales and Purchase Document Form Version Assignments
---

# Sales and Purchase Document Form Version Assignments


You can customize forms for the following Sales, Sales Return,  Purchase, and Purchase Return documents (Customer and Vendor documents):

- **Document 
 Type** - You can create customized forms for a particular document  type (Sales Quote, Sales Order, Sales Invoice, Credit Quote, Credit Order,  Credit Memo, Purchase Quote, Purchase Order, Purchase Receipt, Purchase  Invoice, Debit Quote, Debit Order, or Debit Memo).
- **Document 
 Alias** - You can assign custom forms for a specific document alias,  such as a “Proposal” document alias for Sale Quote or a “Web Order” document  alias for Sales Order.



You can create forms for the above sales and purchase document  types, but you must assign your custom forms to users or groups of users  before they can use them.


The following general rules apply to customized document  form assignments:

- Customized document  alias forms take precedence over customized document type forms assigned.  For example, a “Web Order” custom document alias form assigned to a user  has priority over any customized forms for the Sales Order document type.
- Custom forms assigned  to a user (or group that the user belongs to) take precedence over custom  forms set as a default.
- If you do not assign  customized forms to users and no customized form is set as a default,  users will see the **Everest** forms  included with the product out of the box. These forms are known as **System Forms** and they cannot be assigned  to users.



The following decision tree shows how the system determines  the form to display for a user when the user opens a document alias.


![]({{site.fd_baseurl}}/img/document_alias_forms_display_flow_chart_fd.gif)


**Figure: Decision Tree for Document Alias Form  Display**


When a user opens a document alias, if a customized document  alias form is assigned to the user (or to a group that has the user as  a member), the user sees the customized document alias form. For example,  the user sees a customized “proposal” document alias form.


If a customized document alias form is not directly assigned  but there is a customized document alias form set as a default, the user  sees the default custom document alias form.


If there is no customized document alias form set as a default,  the users sees the customized form for the specific document type assigned  to the user (or to a group that has the user as a member).


If a customized form for the specific document type is not  assigned but there is a customized form for the specific document type  set as a default, the user sees the default custom form for the specific  document type. For example, the user sees the customized sales quote form  that is set as the default.


If there are no customized forms assigned or set as the default,  the user sees the system form for the document type, such as the system  sales quote form.


{:.example}
Susan is a member of the “Telephone Sales”  group. The Telephone Sales group is assigned to the customized “Proposal”  document alias form. A default customized sales quote (document type)  form is set as the default. When Susan opens the “Proposal” document alias,  she sees the customized “Proposal” document alias form and not the customized  sales quote form since the customized document alias form takes precedence  over the customized sales quote form.


{:.see_also}
See also
: [Assign  a Profile Version to a User or Group]({{site.fd_baseurl}}/forms-browser/assign_a_profile_version_to_a_user_or_group.html)

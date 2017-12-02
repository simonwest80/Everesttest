---
title: Transactions
---

# Transactions


**Transaction #**
: This is the unique number used to identify the transaction.  You can have one or more transactions per journal. You can navigate between  transactions in the same journal by clicking the down arrow and selecting  the required transaction number. **Everest**  creates the transaction number automatically.


**![]({{site.acc_baseurl}}/img/act_notes.gif) (Transaction Narration)**
: Click this icon to view the **Transaction 
 Narration** dialog box. Use this dialog box to enter notes for each  transaction in the journal. Notes are not automatically generated for  system journals nor can they be appended manually.


**Date**
: This field displays the date on which the purchase  document was created.


**Created by**
: The user code of the person who created the document  is displayed in this field.


**Vendor**
: This field displays the name and billing address  of the vendor for whom the document was created. You cannot edit the **Vendor** field for a system journal.


**On Credit Hold and Credit Limit**
: These fields display whether the vendor has put  you on credit hold and the current status of the vendors credit limit,  and not the limit at the time of creating the document.
: These details are automatically displayed from the  **Vendor** profile (path: **Purchasing**  > **Vendors** > **Options** > **Edit** > **In 
 New Window** > **Accounting**  tab).
: The credit limit is displayed in the vendor's currency.


**Source**
: This field displays the source type describing the  classification of this transaction. The source type for a Purchase Invoice  is MRC and  for a Debit Memo, it is DRM.  You cannot modify the source type for a system journal.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Source  Types]({{site.sc_chm}}/options/acc-info/source-types/source_types.html)


**Currency**
: The document's currency code is displayed in this  field.


**Exchange Rate**
: The exchange rate for the document is displayed  in this field. The exchange rate is the conversion rate of the foreign  currency to your base currency.
: You cannot modify this rate for system journals.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Foreign  Currency Information - Purchase Documents]({{site.pp_chm}}/purc-proc/doc-profile/contents/tabs/details/for-cur-info/foreign_currency_information_purchase_document.html)


**Document Alias**
: This field displays the document alias for either  purchase receipts, purchase invoices, or debit memos.


| **Document Alias for** | : **Description** |
| **Purchase Receipt** | : Used when your company receives items into inventory. |
| **Purchase Invoice** | : Used to account for your payment liability to the  vendor when your company receives goods or services. |
| **Debit Memo** | : Used when your company receives an allowance for  return of goods or services to a vendor. |



**Document #**
: The document number of the **Purchase 
 Invoice** or **Debit Memo** is  displayed in this field. The document number is automatically generated  when you create the document.
: Inventory adjustments for price protection are accounted  in system purchase journals. Document numbers are automatically generated  for such documents.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Price  Protection]({{site.wm_chm}}/inv-adj/price-protection/price_protection_new.html)


**Vendor Invoice # and Date**
: These fields display the vendors invoice number  and date, if any, specified in the purchase invoice or debit memo.
: ![]({{site.acc_baseurl}}/img/note.gif)  The  due date for payment is computed from the date of the vendor's invoice  if the check box 'Terms from the PI date' is not selected in the Purchase  Invoice.


**Terms**
: The payment terms for the transaction is displayed  in this field.
: ![]({{site.acc_baseurl}}/img/lens.gif) [Payment  Terms - Purchase Documents]({{site.pp_chm}}/purc-proc/doc-profile/contents/tabs/details/payment-information/terms_purchases.html)


**Due Date**
: The date by which you are required to pay the vendor  is displayed in this field. This date is computed based on the payment  terms specified for the document.


{:.see_also}
See also
: [System  Purchase Journal profile - General]({{site.acc_baseurl}}/purchasing/purchasing-through-documents/system-purchase-journals/system_purchase_journal_profile_-_general.html)

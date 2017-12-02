---
title: Retrieve Items from Documents
---

# Retrieve Items from Documents


You can retrieve item information from the following documents:

- Purchase Quote
- Purchase Order
- Purchase Receipt
- Purchase Invoice
- Sales Quote
- Sales Order
- Sales Invoice
- Credit Memo



You can also modify the retrieved information. Retrieving items from  sales documents is useful when you make a single purchase of items present  in more than one purchase or sales document.


{:.example}
If you have received two sales orders and  want to obtain a single quote for all items on these two sales orders,  you can retrieve a copy of each sales order into a purchase quote.


![]({{site.pp_baseurl}}/img/steps.gif)To retrieve items from a document, do the  following:

- From the purchase  document, select **Options** >  **Retrieve** > **Copy****of**. You will see a list of the  specified document types.
- Select the  document type from which items have to be extracted to the current document  profile. You will see the relevant document browser.
- Select the  required records and click **OK**.  The items in the selected document are copied to the current purchase  document.



Alternatively, to retrieve items you can open the document browser,  click the required document, and drag and drop it into the current document  profile.


{:.note}
If you are retrieving Sales Documents, **Everest** prompts whether you want to  copy the **Ship To Address** of the  Sales Document or Customer’s **Bill To 
 Address**. Select your option and click **OK**.


Information pertaining to the vendor of the  original document is not retrieved into the new document.


In case of serialized items, the quantity  fields in the Item Details Grid are not populated with values from the  original item.


If the document that you retrieve contains discontinued items, **Everest** informs you of it. You can choose  to:

- **Retrieve 
 active items** - Select this option to add only active items in the  document to the purchase document.
- **Retrieve 
 active and discontinued items** - Select this option to add all items  in the document (active and discontinued items) to the purchase document.


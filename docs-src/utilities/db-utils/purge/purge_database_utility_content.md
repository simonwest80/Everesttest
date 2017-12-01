---
title: Purge
---

# Purge


The **Purge** utility allows you  to delete quotes, freight information and event log that are no longer  required from the database. When records are purged they are deleted permanently.


The records that you can delete permanently are listed below:

- [Sales  Opportunities]({{site.utl_baseurl}}/misc/purge_sales_opportunities_utility_content.html)
- [Sales  Quote]({{site.utl_baseurl}}/db-utils/purge/purge_sales_quotes_utility_content.html)
- [Credit  Quotes]({{site.utl_baseurl}}/db-utils/purge/purge_credit_quotes_utility_content.html)
- [Purchase  Quotes]({{site.utl_baseurl}}/db-utils/purge/purge_purchase_quotes_utility_content.html)
- [Debit  Quotes]({{site.utl_baseurl}}/db-utils/purge/purge_debit_quotes_utility_content.html)
- [Freight  Rates]({{site.utl_baseurl}}/db-utils/purge/purge_freight_rates_utility_content.html)
- [Freight  Zones]({{site.utl_baseurl}}/db-utils/purge/purge_freight_zones_utility_content.html)
- [Event  History]({{site.utl_baseurl}}/db-utils/purge/purge_event_log_utility_content.html)

: ![]({{site.utl_baseurl}}/img/warning.gif) When a Freight Zone is purged, all  the associated Freight Zone Details and Freight Rates are also purged.


The sequence numbers of the purged quotes are deleted permanently. **Everest** does not re-assign these sequence  numbers to any other quotes. You can however use the purged sequence numbers  by inserting them in the **Location**  profile (path: **File** > **Setup** > **Accounting**  > **Location**/**Sub-Location** > **Options** > **Edit** > **In 
 New Window** > **Invoicing**/**Purchasing** tab).


![]({{site.utl_baseurl}}/img/lens.gif) [Sequence  Numbers]({{site.sc_chm}}/misc/sequence_numbers_departments.html)


![]({{site.utl_baseurl}}/img/example.gif) The  sales quotes numbered 1000 to 1050 are purged. **Everest**  will not re-assign these numbers to any other quotes. You can however  assign these numbers to other quotes from the **Location**  profile.

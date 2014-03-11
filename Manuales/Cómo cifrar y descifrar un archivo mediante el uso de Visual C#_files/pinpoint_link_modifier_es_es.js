(function() {
  var $storeLink = $("#mthdr22 a"),
      linkHref = $storeLink.attr("href"),
      newLinkHref = "http://pinpoint.microsoft.com/es-ES/home?WT.mc_id=es-ES_Perm_Link_SupportMenu_2HP";
      
  if (typeof linkHref === 'string' && linkHref.length > 0) {
    $(".mstHdr a[href='" + linkHref + "']").attr("href", newLinkHref);
  }
})();

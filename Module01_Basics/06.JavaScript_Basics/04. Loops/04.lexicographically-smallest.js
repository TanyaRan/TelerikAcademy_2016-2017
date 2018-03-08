function lexicogrMin() {
    docMinMax(document);
    docMinMax(window);
    docMinMax(navigator);
  }
  
  function docMinMax(objectToParse) {
    let docMin = objectToParse;
    let docMax = objectToParse;
  
    for (var key in objectToParse) {
      if (key < docMin) {
        docMin = key;
      }
  
      if (key > docMax) {
        docMax = key;
      }
    }
  
    console.log('Min :', docMin);
    console.log('Max :', docMax);
  }
  
  // lexicogrMin();
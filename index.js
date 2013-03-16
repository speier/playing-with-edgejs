var edge = require('edge');

var fiboByDigits = edge.func({
  assemblyFile: __dirname + '/lib/FiboLinq/bin/Debug/FiboLinq.dll',
  methodName: 'FindByDigits'
});

fiboByDigits(2012, function(err, term) {
  if (err) throw err;
  console.log('First Fibonacci term with 2012 digits: %dth', term.Number);
});
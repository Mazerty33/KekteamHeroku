'use strict';

describe('carApp.version module', function() {
  beforeEach(module('carApp.version'));

  describe('version service', function() {
    it('should return current version', inject(function(version) {
      expect(version).toEqual('0.1');
    }));
  });
});

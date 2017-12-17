'use strict';

angular.module('carApp.version', [
  'carApp.version.interpolate-filter',
  'carApp.version.version-directive'
])

.value('version', '0.1');

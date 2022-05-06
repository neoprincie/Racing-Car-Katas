use strict;
use warnings;

use Test::More 0.96;

use lib 'lib/TirePressureMonitoringSystem';

require Alarm;

subtest 'foo' => sub {
    my $alarm = new Alarm();

    is( $alarm->alarmOn, '0' )
};

done_testing();
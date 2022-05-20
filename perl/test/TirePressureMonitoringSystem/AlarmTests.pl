use strict;
use warnings;

use Test::More 0.96;
use Test2::Mock;

use lib 'lib/TirePressureMonitoringSystem';
# use lib 'test/TirePressureMonitoringSystem';

require Alarm;
require ISensor;

subtest 'foo' => sub {
    my $mockSensor = Test2::Mock->new(class => "ISensor");
    $mockSensor->override('popNextPressurePsiValue' => 16 );
    $mockSensor = new ISensor();

    my $alarm = new Alarm($mockSensor);

    $alarm->check();

    is( $alarm->alarmOn, '1' )
};

done_testing();
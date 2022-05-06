package Alarm;

use strict;
use warnings;

use lib 'lib/TirePressureMonitoringSystem';

require Sensor;

sub new {
    my ( $class ) = @_;
    my $self = {
        alarmOn => '0',
        lowPressureThreshold => 17,
        highPressureThreshold => 21,
        alarmCount => 0,
        sensor => new Sensor()
    };

    bless $self, $class;

    return $self;
}

sub check {
    my ( $self ) = @_;

    my $psiPressureValue = $self->{sensor}->popNextPressurePsiValue();

    if ($psiPressureValue < $self->{lowPressureThreshold} or $self->{highPressureThreshold} < $psiPressureValue) {
        $self->{alarmOn} = '1';
        $self->{alarmCount} = $self->{alarmCount} + 1;
    }
}

sub alarmOn {
    my ( $self ) = @_;
    return $self->{alarmOn};
}

1;
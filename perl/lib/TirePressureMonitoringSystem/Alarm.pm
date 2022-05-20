package Alarm;

use strict;
use warnings;

use lib 'lib/TirePressureMonitoringSystem';

# require Sensor;

sub new {
    my ( $class, $sensor ) = @_;
    my $self = {
        alarmOn => '0',
        lowPressureThreshold => 17,
        highPressureThreshold => 21,
        alarmCount => 0,
        sensor => $sensor
    };

    bless $self, $class;

    return $self;
}

sub check {
    my ( $self ) = @_;

    my $psiPressureValue = $self->poppNextPressurePsiValue();

    if ($psiPressureValue < $self->{lowPressureThreshold} or $self->{highPressureThreshold} < $psiPressureValue) {
        $self->{alarmOn} = '1';
        $self->{alarmCount} = $self->{alarmCount} + 1;
    }
}

sub poppNextPressurePsiValue {
    my ( $self ) = @_;

    print "um?";

    return $self->{sensor}->popNextPressurePsiValue();
}

sub alarmOn {
    my ( $self ) = @_;
    return $self->{alarmOn};
}

1;
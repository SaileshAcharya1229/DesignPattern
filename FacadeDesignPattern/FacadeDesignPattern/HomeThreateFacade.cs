using FacadeDesignPattern;

class HomeThreateFacade
{
    private RoomLight roomLight;
    private Television television;
    private SoundSystem soundSystem;

    public HomeThreateFacade(RoomLight _roomLight1, Television _television1, SoundSystem _soundSystem1)
    {
        this.roomLight = _roomLight1;
        this.television = _television1;
        this.soundSystem = _soundSystem1;
    }

    public void watchMovie()
    {
        roomLight.lightDim();
        television.switchOnTv();
        soundSystem.switchOnSoundSystem();
    }

    public void stopWatchingMovie()
    {
        roomLight.lightBright();
        television.switchOffTv();
        soundSystem.switchOffSoundSystem();
    }
    

    
}
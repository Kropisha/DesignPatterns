namespace State
{
    interface IWaterState
    {
        void Frost(Water water);
        void Heat(Water water);
    }
}
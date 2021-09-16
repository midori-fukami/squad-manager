﻿using Repository.Entity;

namespace Repository
{
    public interface IPersonRepository
    {
        public int Add(PersonEntity entity);

        public void Update(PersonEntity entity);
    }
}

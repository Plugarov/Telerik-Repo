'use strict';

import * as db from 'data';

export function seed() {
    db.add({
        name: 'Pesho',
        age: 20
    });

    db.add({
        name: 'Maria',
        age: 30
    });
}

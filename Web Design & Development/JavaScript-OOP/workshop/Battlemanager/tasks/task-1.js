function solve() {
    'use strict';

    const ERROR_MESSAGES = {
        INVALID_NAME_TYPE: 'Name must be string!',
        INVALID_NAME_LENGTH: 'Name must be between between 2 and 20 symbols long!',
        INVALID_NAME_SYMBOLS: 'Name can contain only latin symbols and whitespaces!',
        INVALID_MANA: 'Mana must be a positive integer number!',
        INVALID_EFFECT: 'Effect must be a function with 1 parameter!',
        INVALID_DAMAGE: 'Damage must be a positive number that is at most 100!',
        INVALID_HEALTH: 'Health must be a positive number that is at most 200!',
        INVALID_SPEED: 'Speed must be a positive number that is at most 100!',
        INVALID_COUNT: 'Count must be a positive integer number!',
        INVALID_SPELL_OBJECT: 'Passed objects must be Spell-like objects!',
        NOT_ENOUGH_MANA: 'Not enough mana!',
        TARGET_NOT_FOUND: 'Target not found!',
        INVALID_BATTLE_PARTICIPANT: 'Battle participants must be ArmyUnit-like!'
    };

    var spell,
        unit,
        armyUnit,
        commander;

    spell = (function () {
        var spell = Object.create({});

        Object.defineProperty(spell, 'init', {
            value: function (name, manaCost, effect) {
                this.name = name;
                this.manaCost = manaCost;
                this.effect = effect;
                return this;
            }
        });

        Object.defineProperty(spell, 'name', {
            get: function () {
                return this._name;
            },
            set: function (value) {
                this._name = value;
            }
        })

        return spell;
    })();

    unit = (function () {
        var unit = Object.create({});

        Object.defineProperty(unit, 'init', {
            value: function (name, aligment) {
                this.name = name;
                this.aligment = aligment;
            }
        });

        return unit;
    })();

    armyUnit = (function (parent) {
        var armyUnit = Object.create(parent);
        var currentArmyUnitId = 0;

        Object.defineProperty(armyUnit, 'init', {
            value: function (id, damage, health, count, speed) {
                parent.init.call(this, damage, health, count, speed);
                this._id = ++currentArmyUnitId;
                this._damage = damage;
                this._health = health;
                this._count = count;
                this._speed = speed;
                return this;
            }
        });

        return armyUnit;
    })(unit);

    const battlemanager = {
        getSpell: function (name, manaCost, effect) {
            return Object.create(spell).init(name, manaCost, effect);
        },

        getArmyUnit: function (name, aligment, damage, health, count, speed) {
            return Object.create(armyUnit).init(name, aligment, damage, health, count, speed);
        }
    };

    return battlemanager;
}


module.exports = solve;

var module = solve();

var spell = module.getSpell('Magiq', 5, 'destruction');
console.log(spell.name);
var armyUnit = module.getArmyUnit('tank', 'good', 100, 100, 1, 10);
console.log(armyUnit._id);
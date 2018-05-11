import unittest
from flask import current_app
from app import creat_app, db

class BasicTestCase(unittest.TestCase):
    def setUp(self):
        self.app = creat_app('testing')
        self.app_context = self.app.app_context()
        self.app_context.push()
        db.create_all()

    def tearDown(self):
        db.session.remove()
        db.drop_all()
        self.app_context.pop()

    def test_app_exists(self):
        self.assertFalse(current_app is None)

    def test_app_testing(self):
        self.assertTrue(current_app.config['TESTING'])